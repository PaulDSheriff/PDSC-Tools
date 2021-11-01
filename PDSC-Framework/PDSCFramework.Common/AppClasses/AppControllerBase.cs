using System;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDSC.Common;

namespace PDSCFramework.Common
{
  /// <summary>
  /// All your MVC controller classes should inherit from this class
  /// </summary>
  public class AppControllerBase : Controller
  {
    #region Constructor
    public AppControllerBase()
    {
    }

    public AppControllerBase(AppSession session)
    {
      UserSession = session;
    }

    public AppControllerBase(AppSettings settings)
    {
      AppSettings = settings;
    }

    public AppControllerBase(AppSession session, AppSettings settings)
    {
      UserSession = session;
      AppSettings = settings;
    }

    public AppControllerBase(AppSettings settings, ILogger logger)
    {
      AppSettings = settings;
      Logger = logger;
    }

    public AppControllerBase(AppSession session, AppSettings settings, ILogger logger)
    {
      UserSession = session;
      AppSettings = settings;
      Logger = logger;
    }
    #endregion

    #region Constants and Fields
    protected AppSession UserSession { get; set; }
    protected AppSettings AppSettings { get; set; }
    protected ILogger Logger;

    public const string SELECTED_ENTITY = "SelectedEntity";
    public const string CAN_MAKE_API_CALL = "CanMakeApiCall";
    #endregion

    #region Init Method 
    protected virtual void Init(ViewModelBase vm)
    {
      // Get Full URL Path such as http://localhost
      ViewBag.Url = GetUrl();
      // Get URL Path such as /Terms, /Customer, etc.
      ViewBag.Path = GetUrlPath();
      // Get any URL prefix such as msft.pdsa.com
      ViewBag.UrlPrefix = GetUrlPrefix();

      // Set Records Per Page
      vm.PageSize = AppSettings.RecordsPerPage;
      
      if (User != null && User.Identity != null) {
        // Set UserName into view model
        vm.LoginObject = new UserEntity
        {
          IsLoggedIn = User.Identity.IsAuthenticated,
          EmailAddress = User.Identity.Name ?? AppSettings.EmailAliases.Information
        };
        vm.LoginObject.LoginName = vm.LoginObject.EmailAddress;
      }
    }
    #endregion

    #region CacheData Method
    public void CacheData(object data, string key)
    {
      if (data == null) {
        ClearCacheData(key);
      }
      else {
        // Cache data
        HttpContext.Session.SetString(key, JsonSerializer.Serialize(data));
      }
    }
    #endregion

    #region GetCachedData Method
    public T GetCachedData<T>(string key)
    {
      T ret = default;

      if (HttpContext.Session.GetString(key) != null) {
        ret = JsonSerializer.Deserialize<T>(HttpContext.Session.GetString(key));
      }

      return ret;
    }
    #endregion

    #region IsDataCached Method
    public bool IsDataCached(string key)
    {
      return HttpContext.Session.Keys.ToList().Contains(key);
    }
    #endregion

    #region ClearCacheData Method
    public void ClearCacheData(string key)
    {
      // Cache data
      HttpContext.Session.Remove(key);
    }
    #endregion

    #region ObjectToJSONString Method
    public string ObjectToJSONString(object data)
    {
      return JsonSerializer.Serialize(data);
    }
    #endregion

    #region JSONStringToObject Method
    public T JSONStringToObject<T>(string json)
    {
      return JsonSerializer.Deserialize<T>(json);
    }
    #endregion

    #region GetUrl Method
    protected string GetUrl()
    {
      return Request.Scheme + "://" + Request.Host + "/";
    }
    #endregion

    #region GetUrlPath Method
    protected string GetUrlPath()
    {
      string path = Request.Path;
      if (!string.IsNullOrEmpty(path)) {
        if (path.IndexOf("/") >= 0) {
          path = path.Substring(path.LastIndexOf("/") + 1);
        }
        if (path.IndexOf("/") >= 0) {
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
        ret = Request.HttpContext.Connection.RemoteIpAddress.ToString();
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