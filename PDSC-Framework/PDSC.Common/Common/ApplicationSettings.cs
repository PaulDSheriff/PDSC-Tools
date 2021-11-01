using Microsoft.Extensions.Configuration;
using PDSC.Common.Shopping;

namespace PDSC.Common
{
  /// <summary>
  /// Fill in this class with information about your application.
  /// These are normally read in from the appsettings.json file of your application.
  /// </summary>
  public class ApplicationSettings : CommonBase
  {
    #region Constructor
    public ApplicationSettings() : base()
    {
    }

    /// <summary>
    /// Constructor for ApplicationSettings class
    /// </summary>
    public ApplicationSettings(IConfiguration config) : base()
    {
      Configuration = config;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the Application Name
    /// </summary>
    public string ApplicationName { get; set; }

    /// <summary>
    /// Get/Set Configuration Reader
    /// </summary>
    public IConfiguration Configuration { get; set; }

    /// <summary>
    /// Get/Set RecordsPerPage
    /// </summary>
    public int RecordsPerPage { get; set; }

    /// <summary>
    /// Get/Set whether to cache data on a page or not
    /// </summary>
    public bool CacheDataForPage { get; set; }

    /// <summary>
    /// Get/Set the Default Country Code
    /// </summary>
    public string DefaultCountryCode { get; set; }

    /// <summary>
    /// Get/Set the Default State Code
    /// </summary>
    public string DefaultStateCode { get; set; }

    /// <summary>
    /// Get/Set the template name for the welcome letter
    /// </summary>
    public string WelcomeLetterTemplateName { get; set; }

    /// <summary>
    /// Get/Set the site url
    /// </summary>
    public string SiteUrl { get; set; }

    /// <summary>
    /// Get/Set the log file name
    /// </summary>
    public string LogFileName { get; set; }

    /// <summary>
    /// Get/Set the log connection string
    /// </summary>
    public string LogConnectionString { get; set; }

    /// <summary>
    /// Get/Set the Email Aliases
    /// </summary>
    public EmailAliases EmailAliases { get; set; }

    /// <summary>
    /// Get/Set Credit Card Settings
    /// </summary>
    public CreditCardSettings CreditCardSettings { get; set; }

    /// <summary>
    /// Get/Set the Framework connection string
    /// </summary>
    public string FrameworkConnectionString { get; set; }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize the Application Information
    /// </summary>
    public override void Init()
    {
      base.Init();

      EmailAliases = new EmailAliases();
      CreditCardSettings = new CreditCardSettings();
      FrameworkConnectionString = string.Empty;

      RecordsPerPage = 10;
      CacheDataForPage = false;
    }
    #endregion

    #region LoadApplicationSettings Method
    /// <summary>
    /// Override this method to read in the standard PDSC application settings, plus your own settings
    /// </summary>
    public virtual void LoadApplicationSettings()
    {
    }
    #endregion
  }
}
