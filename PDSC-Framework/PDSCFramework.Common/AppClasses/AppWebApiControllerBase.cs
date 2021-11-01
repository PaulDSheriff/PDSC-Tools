using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PDSCFramework.Common
{
  /// <summary>
  /// All your Web API controller class should inherit from this class
  /// </summary>
  public class AppWebApiControllerBase : ControllerBase
  {
    protected bool CanCallApi()
    {
      string isValid = GetCachedData<string>(AppControllerBase.CAN_MAKE_API_CALL);

      return (isValid == "true");
    }

    #region CacheData Method
    public void CacheData(object data, string key)
    {
      // Cache data
      HttpContext.Session.SetString(key, JsonSerializer.Serialize(data));
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
  }
}