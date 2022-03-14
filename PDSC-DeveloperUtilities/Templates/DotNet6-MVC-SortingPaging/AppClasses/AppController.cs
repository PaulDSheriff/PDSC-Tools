#nullable disable

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// All your MVC controller classes should inherit from this class
  /// </summary>
  public class AppController : PDSC.Common.ControllerBase {
    #region Constructor
    public AppController() : base()
    {
    }

    public AppController(AppSession session)
    {
      UserSession = session;
    }

    public AppController(ILogger logger) : base(logger)
    {
    }

    public AppController(AppSession session, ILogger logger) : base(logger)
    {
      UserSession = session;
    }

    public AppController(AppSettings settings, ILogger logger) : base(logger) {
      AppSettings = settings;
    }

    public AppController(AppSession session, AppSettings settings, ILogger logger) : base(logger) {
      UserSession = session;
      AppSettings = settings;
    }
    #endregion

    #region Fields
    protected AppSession UserSession { get; set; }
    protected AppSettings AppSettings { get; set; }    
    #endregion

    #region Init Method 
    protected virtual void Init(AppViewModel vm)
    {
      base.Init();

      // TODO: Initialize any of your properties here
    }
    #endregion
  }
}