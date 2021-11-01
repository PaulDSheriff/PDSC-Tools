using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PDSC.Common;
using PDSC.Common.DataLayer;
using PDSC.Common.EntityLayer;
using PDSCFramework.Common;
using PDSCFramework.DataLayer;
using PDSCFramework.EntityLayer;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace PDSCFramework
{
  public class Startup
  {
    #region Constructor
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    #endregion

    #region Properties
    public IConfiguration Configuration { get; }
    #endregion

    #region ConfigureServices Method
    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // Cookie Consent Support
      ConfigureCookiePolicy(services);

      // The next three lines are for session state
      services.AddDistributedMemoryCache();
      services.AddSession(options =>
      {
        options.IdleTimeout = TimeSpan.FromMinutes(20);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
      });
      services.AddHttpContextAccessor();

      // Add a UserSession object before setting up global action filter AppViewDataFilter
      services.AddScoped<AppSession>();

      // Set global action filters
      services.AddMvc(options =>
      {
        options.Filters.Add<AppViewDataFilter>();
      });

      // Read configuration settings
      ConfigurationSettings(services);

      // Setup the Database Context for the Application
      SetupAppDbContext(services);

      // Setup the Database Context for the PDSC Framework
      SetupFrameworkDbContext(services);

      // Inject services for application
      InjectAppServices(services);

      // Inject services for PDSC Framework
      InjectFrameworkRepositoryServices(services);

      // MVC Support
      services.AddControllersWithViews();

      // Razor Pages Support for Identity
      services.AddRazorPages().AddRazorRuntimeCompilation();
    }
    #endregion

    #region Configure Method
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
      AppSettings settings, ILoggerFactory loggerFactory)
    {
      if (env.IsDevelopment()) {
        //app.UseDeveloperExceptionPage();
        app.UseMigrationsEndPoint();
        app.UseExceptionHandler("/Error/ErrorDevelopment");
      }
      else {
        app.UseExceptionHandler("/Error/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      // Add code to display status code pages
      app.UseStatusCodePages();
      app.UseStatusCodePagesWithReExecute("/Error/StatusCodeReExecute", "?code={0}");

      // Default to HTTPS
      app.UseHttpsRedirection();

      // Allow the use of static HTML
      app.UseStaticFiles();

      // Implement Cookie Policy
      app.UseCookiePolicy();

      // Enable use of Session object
      app.UseSession();

      // Turn on Routing
      app.UseRouting();

      // Read application settings
      settings.LoadApplicationSettings();

      // Helps us get the IP address
      app.UseForwardedHeaders(new ForwardedHeadersOptions
      {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
      });

      // Turn on security
      app.UseAuthentication();
      app.UseAuthorization();

      // Configure Logging
      ConfigureLogging(app, settings);
      loggerFactory.AddSerilog();

      // ***************************************************************************************************
      // *** NOTE: All Custom Middleware must come after UseAuthentication()
      // *** See: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-5.0
      // ***************************************************************************************************

      // Add Global Exception Handling
      app.UseMiddleware<GlobalErrorHandlingMiddleware>();

      // Setup endpoints
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapRazorPages();
        endpoints.MapControllerRoute(name: "unsubscribe",
               pattern: "unsubscribe",
               defaults: new { controller = "Home", action = "Unsubscribe" });
        endpoints.MapControllerRoute(
        name: "PDSALookups",
        pattern: "{area:exists}/{controller=Home}/{action=Index}");
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
        endpoints.MapRazorPages();
      });
    }
    #endregion

    #region ConfigureCookiePolicy Method
    /// <summary>
    /// Use this method to configure cookie consent needed by the user
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    protected void ConfigureCookiePolicy(IServiceCollection services)
    {
      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential 
        // cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        // requires using Microsoft.AspNetCore.Http;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });
    }
    #endregion

    #region SetupAppDbContext Method
    /// <summary>
    /// Use this method to setup EF Database Context for the Application
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    private void SetupAppDbContext(IServiceCollection services)
    {
      services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(
              Configuration.GetConnectionString(PDSCConstants.APPLICATION_CONNECTION_STRING_NAME)));
      services.AddDatabaseDeveloperPageExceptionFilter();

      services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
          .AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
    }
    #endregion

    #region SetupFrameworkDbContext Method
    /// <summary>
    /// Use this method to setup EF Database Context for PDSC Framework
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    private void SetupFrameworkDbContext(IServiceCollection services)
    {
      // Setup DB Context
      services.AddDbContext<PDSCDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString(PDSCConstants.FRAMEWORK_CONNECTION_STRING_NAME)));
    }
    #endregion

    #region ConfigurationSettings Method
    /// <summary>
    /// Use this method to read settings from the appsettings.json file
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    private void ConfigurationSettings(IServiceCollection services)
    {
      // Setup Email Sender
      services.AddTransient<IEmailSender, EmailSender>();

      // Get Email Settings
      services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

      // Create a singleton AppSettings object
      services.AddSingleton<AppSettings, AppSettings>();
    }
    #endregion

    #region InjectAppServices Method
    /// <summary>
    /// Use this method to create services for Dependency Injection
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    private void InjectAppServices(IServiceCollection services)
    {
      // Create scoped versions of Repositories for your Application
      services.AddScoped<IRepository<Person, PersonSearch>, PersonRepository>();
    }
    #endregion

    #region InjectFrameworkServices Method
    /// <summary>
    /// Use this method to create services for Dependency Injection for the PDSC Framework
    /// </summary>
    /// <param name="services">An instance of the IServiceCollection from ASP.NET Core</param>
    private void InjectFrameworkRepositoryServices(IServiceCollection services)
    {
      // Create scoped versions of Repositories
      services.AddScoped<IRepositoryStringPK<CanadianProvince, CanadianProvinceSearch>, CanadianProvinceRepository>();
      services.AddScoped<IRepository<ContactUs, ContactUsSearch>, ContactUsRepository>();
      services.AddScoped<IRepositoryStringPK<Country, CountrySearch>, CountryRepository>();
      services.AddScoped<IRepository<EmailTemplate, EmailTemplateSearch>, EmailTemplateRepository>();
      services.AddScoped<IRepository<FAQ, FAQSearch>, FAQRepository>();
      services.AddScoped<IRepository<LogInfo, LogInfoSearch>, LogInfoRepository>();
      services.AddScoped<IRepository<PersonType, PersonTypeSearch>, PersonTypeRepository>();
      services.AddScoped<IRepository<PrivacyPolicy, PrivacyPolicySearch>, PrivacyPolicyRepository>();
      services.AddScoped<IRepository<SiteTerms, SiteTermsSearch>, SiteTermsRepository>();
      services.AddScoped<IRepositoryStringPK<USStateCode, USStateCodeSearch>, USStateCodeRepository>();
    }
    #endregion

    #region ConfigureLogging Method
    protected void ConfigureLogging(IApplicationBuilder app, AppSettings settings)
    {
      // Create SQL Server options for Serilog
      MSSqlServerSinkOptions options = new()
      {
        SchemaName = "Lookup",
        TableName = "LogInfo"
      };

      // Configure Serilog
      // https://serilog.net/
      // Configuring a Rolling File Sink and a SQL Server Sink
      Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(settings.LogFileName, rollingInterval: RollingInterval.Day)
            .WriteTo.MSSqlServer(
              connectionString: settings.LogConnectionString,
              restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error,
              sinkOptions: options)
            .CreateLogger();

      // Turn on Serilog Diagnostics
      // Serilog.Debugging.SelfLog.Enable(msg => System.Diagnostics.Debug.WriteLine(msg));
    }
    #endregion
  }
}
