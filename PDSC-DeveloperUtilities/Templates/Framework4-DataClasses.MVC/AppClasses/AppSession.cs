using System.Web;

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// Use this class to hold your application session variables
  /// NOTE: The CustomerId and CustomerName properties in here are examples only
  /// </summary>
  public class AppSession {
    #region Sample Properties Stored in Session
    public int? CustomerId
    {
      get
      {
        if (HttpContext.Current.Session["CustomerId"] != null) {
          return (int)HttpContext.Current.Session["CustomerId"];
        }
        else {
          return null;
        }
      }
      set { HttpContext.Current.Session["CustomerId"] = value.Value; }
    }

    public string CustomerName
    {
      get
      {
        if (HttpContext.Current.Session["CustomerName"] != null) {
          return (string)HttpContext.Current.Session["CustomerName"];
        }
        else {
          return null;
        }
      }
      set { HttpContext.Current.Session["CustomerName"] = value; }
    }
    #endregion
  }
}
