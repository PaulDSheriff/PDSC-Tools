using Microsoft.Extensions.Configuration;
using PDSC.Common;

namespace PDSCFramework.Common
{
  /// <summary>
  /// This class loads settings from your appsettings.json file
  /// </summary>
  public class AppSettings : ApplicationSettings
  {
    #region Constructors
    public AppSettings(IConfiguration config) : base(config)
    {
    }
    #endregion

    #region LoadApplicationSettings Method
    public override void LoadApplicationSettings()
    {
      // Load Standard PDSC Framework Settings
      LoadFrameworkSettings();

      // TODO: Read your application settings here


    }
    #endregion

    #region LoadFrameworkSettings Method
    protected void LoadFrameworkSettings()
    {
      // Load all standard PDSC Framework settings
      ApplicationName = Configuration.GetValue<string>("SiteSettings:ApplicationName");
      RecordsPerPage = Configuration.GetValue<int>("SiteSettings:RecordsPerPage");
      CacheDataForPage = Configuration.GetValue<bool>("SiteSettings:CacheDataForPage");
      DefaultCountryCode = Configuration.GetValue<string>("SiteSettings:DefaultCountryCode");
      DefaultStateCode = Configuration.GetValue<string>("SiteSettings:DefaultStateCode");
      WelcomeLetterTemplateName = Configuration.GetValue<string>("SiteSettings:WelcomeLetterTemplateName");
      SiteUrl = Configuration.GetValue<string>("SiteSettings:SiteUrl");
      LogFileName = Configuration.GetValue<string>("SiteSettings:LogFileName");
      LogConnectionString = Configuration.GetValue<string>("ConnectionStrings:FrameworkConnection");

      // Load Email Aliases
      EmailAliases.ContactUs = Configuration.GetValue<string>("EmailAliases:ContactUs");
      EmailAliases.DoNotReply = Configuration.GetValue<string>("EmailAliases:DoNotReply");
      EmailAliases.Information = Configuration.GetValue<string>("EmailAliases:Information");
      EmailAliases.Sales = Configuration.GetValue<string>("EmailAliases:Sales");
      EmailAliases.Support = Configuration.GetValue<string>("EmailAliases:Support");

      // Load Credit Card Info
      CreditCardSettings.ProcessorName = Configuration.GetValue<string>("CreditCardSettings:ProcessorName");
      CreditCardSettings.ClientID = Configuration.GetValue<string>("CreditCardSettings:ClientID");
    }
    #endregion
  }
}