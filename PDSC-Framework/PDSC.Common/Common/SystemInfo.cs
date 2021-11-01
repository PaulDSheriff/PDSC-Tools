using System;
using System.Collections;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;

namespace PDSC.Common
{
  /// <summary>
  /// This class allows you to query various properties of the current running machine.
  /// </summary>
  public class SystemInfo
  {
    #region Constructor
    /// <summary>
    /// Base constructor for the CSSystemInfo class. Gets a reference to the CallingAssembly.
    /// </summary>
    public SystemInfo()
    {
      _CurrentAssm = Assembly.GetCallingAssembly();
      _AssemblyInfo = new AssemblyInfo(_CurrentAssm);
    }
    #endregion

    #region Constants
    private const string _ERROR_MSG = "Can't Retrieve {0}";
    #endregion

    #region Private Variables
    private readonly Assembly _CurrentAssm = null;
    private readonly AssemblyInfo _AssemblyInfo = null;
    #endregion

    #region Public Properties
    /// <summary>
    /// Get the current machine name.
    /// </summary>
    public string MachineName
    {
      get {
        try {
          return Environment.MachineName;
        }
        catch {
          return string.Format(_ERROR_MSG, "Machine Name");
        }
      }
    }

    /// <summary>
    /// Get whether or not the OS is 64 bit.
    /// </summary>
    public bool Is64bitOS
    {
      get { return (Environment.GetEnvironmentVariable("ProgramFiles(x86)") != null); }
    }

    /// <summary>
    /// Gets the Command line. Same as Environment.CommandLine
    /// </summary>
    public string CommandLine
    {
      get {
        try {
          return Environment.CommandLine;
        }
        catch {
          return string.Format(_ERROR_MSG, "Command Line");
        }
      }
    }

    /// <summary>
    /// Gets the SystemDirectory. Same as Environment.SystemDirectory
    /// </summary>
    public string SystemDirectory
    {
      get {
        try {
          return Environment.SystemDirectory;
        }
        catch {
          return string.Format(_ERROR_MSG, "System Directory");
        }
      }
    }

    /// <summary>
    /// Gets the User Domain Name. Same as Environment.UserDomainName.
    /// </summary>
    public string UserDomainName
    {
      get {
        try {
          return Environment.UserDomainName;
        }
        catch {
          return string.Format(_ERROR_MSG, "User Domain Name");
        }
      }
    }

    /// <summary>
    /// Gets the whether or not the current environment is running in UserInteractive mode. Same as Environment.UserInteractive
    /// </summary>
    public string UserInteractive
    {
      get {
        try {
          return Environment.UserInteractive.ToString();
        }
        catch {
          return string.Format(_ERROR_MSG, "User Interactive");
        }
      }
    }

    /// <summary>
    /// Gets the Current Working Set of Memory on this machine. Same as Environment.WorkingSet
    /// </summary>
    public string Memory
    {
      get {
        try {
          return Environment.WorkingSet.ToString();
        }
        catch {
          return string.Format(_ERROR_MSG, "Working Set (Memory)");
        }
      }
    }


    /// <summary>
    /// Gets the current user name. Same as Environment.UserName
    /// </summary>
    public string UserName
    {
      get {
        try {
          return Environment.UserName;
        }
        catch {
          return string.Format(_ERROR_MSG, "User Name");
        }
      }
    }

    /// <summary>
    /// Gets the current EXE's executing path. Same as Application.ExecutablePath.
    /// </summary>
    public string ExecutablePath
    {
      get {
        try {
          return System.Reflection.Assembly.GetEntryAssembly().Location;
        }
        catch {
          return string.Format(_ERROR_MSG, "Executable Path");
        }
      }
    }

    /// <summary>
    /// Gets the current application's startup path. Same as Application.StartupPath.
    /// </summary>
    public string StartUpPath
    {
      get {
        try {
          return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        }
        catch {
          return string.Format(_ERROR_MSG, "Startup Path");
        }
      }
    }

    /// <summary>
    /// Returns the location of the common application data path. Same as Application.CommonAppDataPath.
    /// </summary>
    public string CommonAppDataPath
    {
      get {
        try {
          return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        }
        catch {
          return string.Format(_ERROR_MSG, "Common Application Data Path");
        }
      }
    }

    /// <summary>
    /// Gets the current users application data path. Same as Application.UserAppDataPath.
    /// </summary>
    public string UserAppDataPath
    {
      get {
        try {
          return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }
        catch {
          return string.Format(_ERROR_MSG, "User Application Data Path");
        }
      }
    }

    /// <summary>
    /// Gets the current application's culture name. Same as Application.CurrentCulture.Name
    /// </summary>
    public string CurrentCulture
    {
      get {
        try {
          return System.Globalization.CultureInfo.CurrentCulture.Name;
        }
        catch {
          return string.Format(_ERROR_MSG, "Current Culture");
        }
      }
    }

    /// <summary>
    /// Gets the currently loaded assemblies
    /// </summary>
    public string LoadedAssemblies
    {
      get {
        try {
          return AssembliesGet();
        }
        catch {
          return string.Format(_ERROR_MSG, "Loaded Assemblies");
        }
      }
    }

    /// <summary>
    /// Gets any environment variables passed into this EXE
    /// </summary>
    public string EnvVariables
    {
      get {
        try {
          return EnvVariablesGet();
        }
        catch {
          return string.Format(_ERROR_MSG, "Environment Variables");
        }
      }
    }

    /// <summary>
    /// Gets the Current Directory. Same as Environment.CurrentDirectory.
    /// </summary>
    public string CurrentDirectory
    {
      get {
        try {
          return Environment.CurrentDirectory;
        }
        catch {
          return string.Format(_ERROR_MSG, "Current Directory");
        }
      }
    }

    /// <summary>
    /// Gets the Operating System Version.
    /// </summary>
    public string OSVersion
    {
      get {
        try {
          return Environment.OSVersion.ToString();
        }
        catch {
          return string.Format(_ERROR_MSG, "Operating System Version");
        }
      }
    }

    /// <summary>
    /// Gets the Operating System Name.
    /// </summary>
    public string OSName
    {
      get {
        try {
          string ret = string.Empty;

          switch (Environment.OSVersion.Version.Major) {
            case 6:
              if (Environment.OSVersion.Version.Minor == 0)
                ret = "Windows Vista";
              else if (Environment.OSVersion.Version.Minor == 1)
                ret = "Windows 7";
              else if (Environment.OSVersion.Version.Minor == 2) {
                ret = "Windows 8 or 10";
              }

              break;
            case 5:
              if (Environment.OSVersion.Version.Minor == 0)
                ret = "Windows 2000";
              else if (Environment.OSVersion.Version.Minor == 1)
                ret = "Windows XP";

              break;
            case 4:
              ret = "Windows NT";
              break;
            default:
              ret = "Windows 98";
              break;
          }

          return ret;
        }
        catch {
          return string.Format(_ERROR_MSG, "Operating System Name");
        }
      }
    }


    /// <summary>
    /// Gets the Current Stack Trace. Same as Environment.StackTrace.
    /// </summary>
    public string StackTrace
    {
      get {
        try {
          return Environment.StackTrace;
        }
        catch {
          return string.Format(_ERROR_MSG, "Stack Trace");
        }
      }
    }


    /// <summary>
    /// Gets the Program Files path. Usually C:\Program Files or C:\Program Files (x86).
    /// </summary>
    public string ProgramFilesPath
    {
      get {
        try {
          return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        }
        catch (Exception) {
          return string.Format(_ERROR_MSG, "Program Files Path");
        }
      }
    }

    /// <summary>
    /// Gets the Current TickCount since Midnight. Same as Environment.TickCount.
    /// </summary>
    public string TickCount
    {
      get {
        try {
          return Environment.TickCount.ToString();
        }
        catch {
          return string.Format(_ERROR_MSG, "Tick Count");
        }
      }
    }

    /// <summary>
    /// Gets the current thread name.
    /// </summary>
    public string ThreadName
    {
      get {
        try {
          return Thread.CurrentThread.Name;
        }
        catch {
          return string.Format(_ERROR_MSG, "Current Thread Name");
        }
      }
    }

    /// <summary>
    /// Gets the current executing Assembly's Full Name.
    /// </summary>
    public string AssemblyName
    {
      get {
        try {
          return Assembly.GetExecutingAssembly().FullName;
        }
        catch {
          return string.Format(_ERROR_MSG, "Assembly Name");
        }
      }
    }

    /// <summary>
    /// Gets the Main Application's Assembly Full Name.
    /// </summary>
    public string MainAssemblyName
    {
      get {
        try {
          return Assembly.GetExecutingAssembly().FullName;
        }
        catch {
          return string.Format(_ERROR_MSG, "Main Assembly Name");
        }
      }
    }

    /// <summary>
    /// The Current Domain's Friendly Name. Same as AppDomain.CurrentDomain.FriendlyName.
    /// </summary>
    public string AppDomainName
    {
      get {
        try {
          return AppDomain.CurrentDomain.FriendlyName;
        }
        catch {
          return string.Format(_ERROR_MSG, "Application Domain Name");
        }
      }
    }

    /// <summary>
    /// Gets the current application's company name.
    /// </summary>
    public string CompanyName
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Company;
        }
        catch {
          return string.Format(_ERROR_MSG, "Company Name");
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the current application's product name.
    /// </summary>
    public string ProductName
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Product;
        }
        catch {
          return string.Format(_ERROR_MSG, "Product Name");
        }

        return ret;
      }

    }

    /// <summary>
    /// Gets the current application's description.
    /// </summary>
    public string Description
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Description;
        }
        catch {
          return string.Format(_ERROR_MSG, "Description");
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the current application's title.
    /// </summary>
    public string Title
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Title;
        }
        catch {
          return string.Format(_ERROR_MSG, "Title");
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the current application's copyright.
    /// </summary>
    public string Copyright
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Copyright;
        }
        catch {
          return string.Format(_ERROR_MSG, "Copyright");
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the current application's product version.
    /// </summary>
    public string ProductVersion
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Version;
        }
        catch {
          return string.Format(_ERROR_MSG, "Product Version");
        }

        return ret;
      }
    }

    /// <summary>
    /// Gets the current application's Product Version.
    /// </summary>
    public string Version
    {
      get {
        string ret;

        try {
          ret = _AssemblyInfo.Version;
        }
        catch {
          return string.Format(_ERROR_MSG, "Version");
        }

        return ret;
      }
    }

    /// <summary>
    /// Returns the current user language such as 'en-US' or 'es-MX' for the current thread of execution
    /// </summary>
    public string UserLanguage
    {
      get {
        return CultureInfo.CurrentCulture.Name;
      }
    }
    #endregion

    #region IPAddress Method
    /// <summary>
    /// Gets all IPAddresses for the current machine separated by a CRLF.
    /// </summary>
    /// <returns>All IPAddresses for the current machine.</returns>
    public string IPAddresses()
    {
      return IPAddresses(Environment.NewLine);
    }

    /// <summary>
    /// Returns the IP Addresses on the current machine 
    /// </summary>
    /// <param name="delimiter">The delimiter used to separate all IP addresses</param>
    /// <returns>All IP addresses on the machine</returns>
    public string IPAddresses(string delimiter)
    {
      StringBuilder sb = new(1024);
      IPHostEntry iphe;
      string delim = string.Empty;

      try {
        iphe = Dns.GetHostEntry(Environment.MachineName);

        for (int index = 0; index <= iphe.AddressList.Length - 1; index++) {
          sb.Append(delim + iphe.AddressList[index].ToString());
          delim = delimiter;
        }
      }
      catch {
      }

      return sb.ToString();
    }
    #endregion

    #region GetAllSystemInfo()
    /// <summary>
    /// Retrieves all system information properties from the CSSystemInfo class and presents them in CRLF delimited string.
    /// </summary>
    /// <returns>A string with all the system information.</returns>
    public string GetAllSystemInfo()
    {
      return GetAllSystemInfo(Environment.NewLine, true);
    }

    /// <summary>
    /// Retrieves all system information properties from the CSSystemInfo class and presents them in a string separated by the delimiter passed in.
    /// </summary>
    /// <param name="delimiter">The delimiter to separate all the properties</param>
    /// <returns>A string with all the system information.</returns>
    public string GetAllSystemInfo(string delimiter)
    {
      return GetAllSystemInfo(delimiter, true);
    }

    /// <summary>
    /// Retrieves all system information properties from the CSSystemInfo class and presents them in a string separated by the delimiter passed in.
    /// </summary>
    /// <param name="includePersonalInfo">Whether or not to return personal info</param>
    /// <returns>A string with all the system information plus personal info.</returns>
    public string GetAllSystemInfo(bool includePersonalInfo)
    {
      return GetAllSystemInfo(Environment.NewLine, includePersonalInfo);
    }

    /// <summary>
    /// Retrieves all system information properties from the CSSystemInfo class and presents them in a string separated by the delimiter passed in.
    /// </summary>
    /// <param name="delimiter">The delimiter to separate all the properties</param>
    /// <param name="includePersonalInfo">Whether or not to return personal info</param>
    /// <returns>A string with all the system information.</returns>
    public string GetAllSystemInfo(string delimiter, bool includePersonalInfo)
    {
      StringBuilder sb = new(1024);

      sb.Append("DateTime=" + DateTime.Now.ToString() + delimiter);
      if (includePersonalInfo) {
        sb.Append("MachineName=" + MachineName + delimiter);
      }
      sb.Append("IP Address(es)" + delimiter + IPAddresses(delimiter) + delimiter);
      sb.Append("CurrentDirectory=" + CurrentDirectory + delimiter);
      sb.Append("OSVersion=" + OSVersion + delimiter);
      sb.Append("OSName=" + OSName + delimiter);
      sb.Append("Is64Bit=" + Is64bitOS.ToString() + delimiter);
      sb.Append("SystemDirectory=" + SystemDirectory + delimiter);
      sb.Append("TickCount=" + TickCount + delimiter);
      if (includePersonalInfo) {
        sb.Append("UserDomainName=" + UserDomainName + delimiter);
      }
      sb.Append("UserInteractive=" + UserInteractive + delimiter);
      sb.Append("Memory=" + Memory + delimiter);
      if (includePersonalInfo) {
        sb.Append("UserName=" + UserName + delimiter);
      }
      sb.Append("ThreadName=" + ThreadName + delimiter);
      sb.Append("MainAssemblyName=" + MainAssemblyName + delimiter);
      sb.Append("CurrentAssemblyName=" + AssemblyName + delimiter);
      sb.Append("AppDomainName=" + AppDomainName + delimiter);
      sb.Append("ExecutablePath=" + ExecutablePath + delimiter);
      sb.Append("StartUpPath=" + StartUpPath + delimiter);
      sb.Append("ProgramFilesPath=" + ProgramFilesPath + delimiter);
      sb.Append("CurrentCulture=" + CurrentCulture + delimiter);
      sb.Append("CompanyName=" + CompanyName + delimiter);
      sb.Append("ProductName=" + ProductName + delimiter);
      sb.Append("ProductVersion=" + ProductVersion + delimiter);
      sb.Append("Description=" + Description + delimiter);
      sb.Append("Title=" + Title + delimiter);
      sb.Append("Copyright=" + Copyright + delimiter);
      sb.Append("UserLanguage=" + UserLanguage + delimiter);
      sb.Append("ApplicationVersion=" + Version);

      return sb.ToString();
    }
    #endregion

    #region EnvVariablesGet Method
    /// <summary>
    /// Gets all environment variables separated by a CRLF.
    /// </summary>
    /// <returns>All environment variables.</returns>
    public string EnvVariablesGet()
    {
      return EnvVariablesGet(Environment.NewLine);
    }

    /// <summary>
    /// Gets all environment variables in a string separated by the delimiter you pass in.
    /// </summary>
    /// <param name="delimiter">The delimiter to use to separate all environment variables.</param>
    /// <returns>All environment variables.</returns>
    public string EnvVariablesGet(string delimiter)
    {
      ICollection coll;
      DictionaryEntry[] deArray;
      StringBuilder sb = new(1024);

      try {
        coll = System.Environment.GetEnvironmentVariables();
        deArray = new System.Collections.DictionaryEntry[coll.Count];
        coll.CopyTo(deArray, 0);

        foreach (DictionaryEntry de in deArray) {
          sb.Append(de.Key.ToString() + " - " + de.Value.ToString() + delimiter);
        }
      }
      catch {
      }

      return sb.ToString();
    }
    #endregion

    #region GetUserAppDataPath Method
    /// <summary>
    /// Get's the user's App Data Path in the form:
    /// C:\Users\YOUR NAME\AppData\Roaming\COMPANY NAME\APPLICATION NAME\APPLICATION VERSION
    /// </summary>
    /// <returns>Returns a string to the user's personal application data path</returns>
    public string GetUserAppDataPath()
    {
      string path;
      Assembly assm = null;
      Type at;
      object[] r;

      try {
        // Get the .EXE assembly
        assm = Assembly.GetEntryAssembly();
        // Get a 'Type' of the AssemblyCompanyAttribute
        at = typeof(AssemblyCompanyAttribute);
        // Get a collection of custom attributes from the .EXE assembly
        r = assm.GetCustomAttributes(at, false);
        // Get the Company Attribute
        AssemblyCompanyAttribute ct =
                      ((AssemblyCompanyAttribute)(r[0]));
        // Build the User App Data Path
        path = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
        path += @"\" + ct.Company;
        path += @"\" + assm.GetName().Name;
        path += @"\" + assm.GetName().Version.ToString();
      }
      catch {
        path = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
        path += @"\Company";
        if (assm != null) {
          path += @"\" + assm.GetName().Name;
          path += @"\" + assm.GetName().Version.ToString();
        }
        else
          path += @"\Assembly\1.0.0.0";
      }

      return path;
    }
    #endregion

    #region AssembliesGet Method
    /// <summary>
    /// Get all loaded assemblies in the current EXE separated by a CRLF.
    /// </summary>
    /// <returns>All assemblies currently loaded.</returns>
    public string AssembliesGet()
    {
      return AssembliesGet(Environment.NewLine);
    }

    /// <summary>
    /// Get all loaded assemblies in the current EXE separated by a CRLF.
    /// </summary>
    /// <param name="delimiter">The delimiter used to separate the assemblies.</param>
    /// <returns>All assemblies currently loaded.</returns>
    public string AssembliesGet(string delimiter)
    {
      Assembly[] assmArray;
      StringBuilder sb = new(1024);

      assmArray = AppDomain.CurrentDomain.GetAssemblies();

      foreach (Assembly assm in assmArray) {
        sb.Append(assm.FullName + delimiter);
      }

      return sb.ToString();
    }
    #endregion

    #region ToString Override
    /// <summary>
    /// Returns all System Information in a CRLF delimited string
    /// </summary>
    /// <returns>All system information</returns>
    public override string ToString()
    {
      return GetAllSystemInfo();
    }
    #endregion
  }
}
