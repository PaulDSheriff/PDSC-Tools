#nullable disable

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// Use this class to hold your application session variables
  /// NOTE: The CustomerId and CustomerName properties in here are examples only
  /// </summary>
  public class AppSession
  {
    #region Constructor
    public AppSession(IHttpContextAccessor httpAccessor) : base()
    {
      HttpAccessor = httpAccessor;
    }
    #endregion

    #region Fields
    protected readonly IHttpContextAccessor HttpAccessor;
    #endregion

    #region Sample Properties Stored in Session
    public int? CustomerId
    {
      get { return HttpAccessor.HttpContext.Session.GetInt32("CustomerId"); }
      set { HttpAccessor.HttpContext.Session.SetInt32("CustomerId", value.Value); }
    }

    public string CustomerName
    {
      get { return HttpAccessor.HttpContext.Session.GetString("CustomerName"); }
      set { HttpAccessor.HttpContext.Session.SetString("CustomerName", value); }
    }
    #endregion
  }
}
