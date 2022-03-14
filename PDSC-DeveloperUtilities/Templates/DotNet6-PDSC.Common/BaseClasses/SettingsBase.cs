#nullable disable

using Microsoft.Extensions.Configuration;

namespace PDSC.Common {
  /// <summary>
  /// This class reads those common properties that 
  /// These are normally read in from the appsettings.json file of your application.
  /// </summary>
  public class SettingsBase : CommonBase {
    #region Constructor
    public SettingsBase() : base() {
    }

    /// <summary>
    /// Constructor for ApplicationSettings class
    /// </summary>
    public SettingsBase(IConfiguration config) : base() {
      Configuration = config;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set Configuration Reader
    /// </summary>
    public IConfiguration Configuration { get; set; }

    /// <summary>
    /// Get/Set the Default Connection String
    /// </summary>
    public string DefaultConnectionString { get; set; }

    /// <summary>
    /// Get/Set the Application Name
    /// </summary>
    public string ApplicationName { get; set; }

    /// <summary>
    /// Get/Set RecordsPerPage
    /// </summary>
    public int RecordsPerPage { get; set; }

    /// <summary>
    /// Get/Set the log file name
    /// </summary>
    public string LogFileName { get; set; }

    /// <summary>
    /// Get/Set the site url
    /// </summary>
    public string SiteUrl { get; set; }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize the Application Information
    /// </summary>
    public override void Init() {
      base.Init();

      RecordsPerPage = 10;
    }
    #endregion

    #region LoadApplicationSettings Method
    /// <summary>
    /// Override this method to read in the standard PDSC application settings, plus your own settings
    /// </summary>
    public virtual void LoadApplicationSettings() {
      // TODO: Load all standard settings
      //DefaultConnectionString = Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
      //ApplicationName = Configuration.GetValue<string>("SiteSettings:ApplicationName");
      //RecordsPerPage = Configuration.GetValue<int>("SiteSettings:RecordsPerPage");
      //SiteUrl = Configuration.GetValue<string>("SiteSettings:SiteUrl");
      //LogFileName = Configuration.GetValue<string>("SiteSettings:LogFileName");
    }
    #endregion
  }
}
