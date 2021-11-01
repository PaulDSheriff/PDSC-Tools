using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PDSC.Common
{
  /// <summary>
  /// Class with various methods
  /// </summary>
  public class PDSCHelper
  {
    #region GetCurrentUserName Method
    /// <summary>
    /// Attempt to get the user name from the current thread of execution
    /// </summary>
    /// <returns>A user name, or "Unknown" if it can't be retrieved</returns>
    public static string GetCurrentUserName() {
      string ret = string.Empty;

      try {
        ret = System.Threading.Thread.CurrentPrincipal.Identity.Name;
      }
      catch { }

      if (string.IsNullOrEmpty(ret)) {
        ret = PDSCConstants.DEFAULT_LOGIN_NAME;
      }

      return ret;
    }
    #endregion
    
    #region ReturnImageForImgElement Method
    /// <summary>
    /// Pass in a byte array to return a base64 encoded string suitable for using in the src attribute of an &gt;img&lt; element.
    /// </summary>
    /// <param name="blob">The image as a byte array</param>
    /// <param name="blobType">The type of blob (image/jpg, image/gif, file/pdf, etc.)</param>
    /// <returns>A string</returns>
    public static string ReturnImageForImgElement(byte[] blob, string blobType) {
      string value;
      string imgSource = string.Empty;

      if (blob != null) {
        value = Convert.ToBase64String(blob);
        imgSource = string.Format("data:{0};base64,{1}", blobType, value);
      }

      return imgSource;
    }
    #endregion 
  }
}
