using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace PDSC.Common {
  /// <summary>
  /// All your MVC controller classes should inherit from this class
  /// </summary>
  public class ControllerBase : Controller
  {
    #region Init Method 
    protected virtual void Init()
    {
      // Get Full URL Path such as http://localhost
      ViewBag.Url = GetUrl();
      // Get URL Path such as /Terms, /Customer, etc.
      ViewBag.Path = GetUrlPath();
      // Get any URL prefix such as msft.pdsa.com
      ViewBag.UrlPrefix = GetUrlPrefix();
    }
    #endregion

    #region GetUrl Method
    protected string GetUrl()
    {
      return Request.Url.ToString();
    }
    #endregion

    #region GetUrlPath Method
    protected string GetUrlPath()
    {
      string path = Request.Path;
      if (!string.IsNullOrEmpty(path)) {
        if (path.Contains("/")) {
          path = path.Substring(path.LastIndexOf("/") + 1);
        }
        if (path.Contains("/")) {
          path = path.Substring(path.LastIndexOf("/") + 1);
        }
      }

      return path;
    }
    #endregion

    #region GetUrlPrefix Method
    public virtual string GetUrlPrefix()
    {
      string url = HttpContext.Request.Path;

      if (!string.IsNullOrEmpty(url)) {
        if (url.Contains(".")) {
          // If we receive a domain such as "msft.mydomain.com",
          // strip off the "mydomain" and
          // the "msft" string is then used as a lookup into the /Json/PageSequence.json file
          url = url.Substring(0, url.IndexOf("."));
        }
      }

      return url;
    }
    #endregion

    #region GetRemoteIPAddress Method
    protected virtual string GetRemoteIPAddress()
    {
      string ret = "http://localhost";

      // Attempt to get Remote IP Address
      try {
        ret = Request.UserHostAddress;
      }
      catch (Exception ex) {
        Debug.WriteLine(ex.ToString());
      }

      return ret;
    }
    #endregion

    #region ShortenText Method
    public static string ShortenText(string text, int length = 50)
    {
      if (text.Length > length) {
        text = text.Substring(0, length);
      }

      return text;
    }
    #endregion
  }
}