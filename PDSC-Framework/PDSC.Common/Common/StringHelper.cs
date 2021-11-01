using System;
using System.Text.RegularExpressions;

namespace PDSC.Common
{
  /// <summary>
  /// This class has several helper methods to help you work with strings.
  /// </summary>
  public class StringHelper
  {
    /// <summary>
    /// Is the value passed in a valid email format?
    /// </summary>
    /// <param name="email">The email to check</param>
    /// <returns>True if the email is valid, otherwise false.</returns>
    public static bool IsValidEmail(string email)
    {
      return Regex.IsMatch(email, (@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"));
    }

    /// <summary>
    /// Is the value passed in a valid US phone format?
    /// </summary>
    /// <param name="phone">The phone to check</param>
    /// <returns>True if the phone is valid, otherwise false.</returns>
    public static bool IsValidUSPhoneNumber(string phone)
    {
      phone = phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace(".", "");

      return phone.Length == 10;
    }

    /// <summary>
    /// Pass in a phone number and this method will strip out all other formatting and return nnn-nnn-nnnn format.
    /// </summary>
    /// <param name="phone">The phone to check</param>
    /// <returns>A phone number in nnn-nnn-nnnn format</returns>
    public static string CreateUSPhoneNumberWithDashes(string phone)
    {
      string value = phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace(".", "");

      if (value.Length == 10) {        
        phone = value.Substring(0, 3) + "-" + value.Substring(3, 3) + "-" + value.Substring(6);
      }

      return phone;
    }

    /// <summary>
    /// Pass in a phone number and this method will strip out all other formatting and return (nnn) nnn-nnnn format.
    /// </summary>
    /// <param name="phone">The phone to check</param>
    /// <returns>A phone number in (nnn) nnn-nnnn format</returns>
    public static string CreateUSPhoneNumberWithParens(string phone)
    {
      string value = phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Replace(".", "");

      if (value.Length == 10) {
        phone = "(" + value.Substring(0, 3) + ") " + value.Substring(3, 3) + "-" + value.Substring(6);
      }

      return phone;
    }

    /// <summary>
    /// Convert a string to a boolean
    /// All these values "1, -1, True, true, T, t, Yes, yes, Y, y" return 'true'
    /// All these values "0, False, false, F, f, No, no, N, n" return 'false'
    /// </summary>
    /// <param name="value">value to convert to boolean</param>
    /// <returns>Boolean</returns>
    public static bool StringToBoolean(string value)
    {
      var ret = value.ToLower() switch
      {
        "true" or "t" or "yes" or "y" or "1" or "-1" => true,
        "false" or "f" or "no" or "n" or "0" => false,
        _ => false,
      };
      return ret;
    }
        
    /// <summary>
    /// This method will accept an Enumeration for special path. These Enumeration will be expanded into their appropriate full paths.
    /// <para>NOTE: None of the above tokens has a trailing backslash, so you need to add one if required.</para>
    /// </summary>
    /// <param name="SpecialFolderNameType">An Enumeration for special folder</param>
    /// <returns>The full special folder name</returns>
    public static string ExpandSpecialFolders(SpecialFolderNameTypes SpecialFolderNameType)
    {
      return ExpandSpecialFolders("[" + SpecialFolderNameType.ToString() + "]");
    }

    /// <summary>
    /// This method will accept any of the Environment.SpecialFolder enumerations in the format [SpecialFolderEnum].
    /// This method will also accept any path with the following special tokens in that path. These tokens will be expanded into their appropriate full paths.
    /// <para>[AppPath] = The folder where the application is installed</para>
    /// <para>     Example: C:\Program Files\YourAppName</para>
    /// <para>[UserAppData] = Your unique storage area for this application</para>
    /// <para>     Example: C:\Users\[YourLoginName]\AppData\Roaming\Company\YourAppName\1.0.0.0</para>
    /// <para>[MyDocuments] = Generate under your "My Documents" folder</para>
    /// <para>     Example: C:\Users\[YourLoginName]\Documents</para>
    /// <para>[ConfigFile] = The .Config file for the current .EXE file</para>
    /// <para>     Example: C:\MyApp\MyApp.exe.config</para>
    /// <para>[ProgramFiles] = The folder where your programs are installed</para>
    /// <para>     Example: C:\Program Files (x86)</para>
    /// <para>[TEMP] = The TEMP folder on your machine</para>
    /// <para>     Example: C:\Temp</para>
    /// <para>[TMP] = The TMP folder on your machine</para>
    /// <para>     Example: C:\Temp</para>
    /// <para>NOTE: None of the above tokens has a trailing backslash, so you need to add one if required.</para>
    /// </summary>
    /// <param name="folderName">The folder name with the special token in it</param>
    /// <returns>The full special folder name</returns>
    public static string ExpandSpecialFolders(string folderName)
    {
      SystemInfo si = new();
      string token;
      string folder;
      string temp;
      Environment.SpecialFolder sp;

      if (folderName == null)
        folderName = string.Empty;
      else {
        if (folderName.Trim() == string.Empty) {
          folderName = FileCommon.GetCurrentDirectory();
        }
        if (folderName.Contains("[AppPath]")) {
          folderName = folderName.Replace("[AppPath]", FileCommon.GetCurrentDirectory());
        }
        if (folderName.Contains("[UserAppData]")) {
          folderName = folderName.Replace("[UserAppData]", si.GetUserAppDataPath());
        }
        if (folderName.Contains("[MyDocuments]")) {
          folderName = folderName.Replace("[MyDocuments]", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }      
        if (folderName.Contains("[ProgramFiles]")) {
          folderName = folderName.Replace("[ProgramFiles]", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
        }
        if (folderName.Contains("[TEMP]")) {
          folderName = folderName.Replace("[TEMP]", Environment.GetEnvironmentVariable("TEMP"));
        }
        if (folderName.Contains("[TMP]")) {
          folderName = folderName.Replace("[TMP]", Environment.GetEnvironmentVariable("TMP"));
        }
        // If we got to here and we still have tokens, look for any Environment.Special folder
        if (folderName.Contains("[") && folderName.Contains("]")) {
          token = folderName.Substring(0, folderName.IndexOf("]") + 1);
          temp = folderName.Substring(1, folderName.IndexOf("]") - 1);
          try {
            sp = (Environment.SpecialFolder)Enum.Parse(typeof(Environment.SpecialFolder), temp);
            folder = Environment.GetFolderPath(sp);
            folderName = folderName.Replace(token, folder);
          }
          catch { }
        }
      }

      return folderName;
    }

    /// <summary>
    /// Pass in a string to this method that has one of the special tokens in it and that token will be replaced with 
    /// the corresponding variables as described below.
    /// <para>[UserName] = The user name that is running this application as retrieved from Environment.UserName</para>
    /// <para>[Domain] = The current domain that this application is running on as retrieved from Environment.UserDomainName</para>
    /// <para>[MachineName] = The current machine name that this application is running on as retrieved from Environment.MachineName</para>
    /// </summary>
    /// <param name="value">The string with the special token in it</param>
    /// <returns>The new string with the tokens replaced</returns>
    public static string ExpandSpecialTokens(string value)
    {
      if (value.Contains("[Domain]"))
        value = value.Replace("[Domain]", Environment.UserDomainName);
      if (value.Contains("[UserName]"))
        value = value.Replace("[UserName]", Environment.UserName);
      if (value.Contains("[MachineName]"))
        value = value.Replace("[MachineName]", Environment.MachineName);

      return value;
    }

    /// <summary>
    /// Looks for UID, User Id, Pwd, Password, etc. in a connection string and replaces their 'values' with astericks.
    /// </summary>
    /// <param name="connectString">The connection string to check</param>
    /// <returns>A string with hidden user id and password values</returns>
    public static string HideLoginInfoForConnectionString(string connectString)
    {
      int index;
      string[] parts;

      connectString = connectString.Trim();
      if (connectString.Length > 0) {
        if (!(connectString.EndsWith(";"))) {
          connectString += ";";
        }

        parts = connectString.Split(';');
        for (index = 0; index <= parts.Length - 1; index++) {
          if (parts[index].ToLower().IndexOf("uid=") >= 0) {
            parts[index] = "uid=***********";
          }
          if (parts[index].ToLower().IndexOf("user id=") >= 0) {
            parts[index] = "user id=***********";
          }
          if (parts[index].ToLower().IndexOf("pwd=") >= 0) {
            parts[index] = "pwd=***********";
          }
          if (parts[index].ToLower().IndexOf("password=") >= 0) {
            parts[index] = "password=***********";
          }
        }

        connectString = string.Join(";", parts);
      }

      return connectString;
    }
  }
}
