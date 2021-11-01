using Microsoft.AspNetCore.Http;

namespace PDSCFramework.Common
{
  /// <summary>
  /// Use this class to hold your application session variables
  /// NOTE: The CustomerId and CustomerName properties in here are examples only
  /// </summary>
  public class AppSession
  {
    #region Constructor
    public AppSession(IHttpContextAccessor httpAccessor)
    {
      _httpAccessor = httpAccessor;
    }
    #endregion

    #region Fields
    protected readonly IHttpContextAccessor _httpAccessor;
    #endregion

    #region Sample Properties Stored in Session
    public int? CustomerId
    {
      get { return _httpAccessor.HttpContext.Session.GetInt32("CustomerId"); }
      set { _httpAccessor.HttpContext.Session.SetInt32("CustomerId", value.Value); }
    }

    public string CustomerName
    {
      get { return _httpAccessor.HttpContext.Session.GetString("CustomerName"); }
      set { _httpAccessor.HttpContext.Session.SetString("CustomerName", value); }
    }
    #endregion
  }
}
