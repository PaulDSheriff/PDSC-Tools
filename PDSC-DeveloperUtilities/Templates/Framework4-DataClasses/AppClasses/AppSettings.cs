using PDSC.Common;

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// This class loads settings from your Web.config file
  /// </summary>
  public class AppSettings : SettingsBase
  {
    #region LoadApplicationSettings Method
    public override void LoadApplicationSettings()
    {
      // Load common application settings
      base.LoadApplicationSettings();

      // TODO: Read your application settings here
      // ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
    }
    #endregion
  }
}