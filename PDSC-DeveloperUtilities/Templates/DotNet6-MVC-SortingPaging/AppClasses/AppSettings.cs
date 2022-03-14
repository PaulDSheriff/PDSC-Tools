#nullable disable

using PDSC.Common;

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// This class loads settings from your appsettings.json file
  /// </summary>
  public class AppSettings : SettingsBase
  {
    #region Constructors
    public AppSettings(IConfiguration config) : base(config)
    {
    }
    #endregion

    #region LoadApplicationSettings Method
    public override void LoadApplicationSettings()
    {
      // Load common application settings
      base.LoadApplicationSettings();

      // TODO: Read your application settings here
      // ApplicationName = Configuration.GetValue<string>("SiteSettings:ApplicationName");

    }
    #endregion
  }
}