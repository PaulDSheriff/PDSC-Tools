using System;

namespace PDSC.Common
{
  /// <summary>
  /// Class for all constants used throughout the PDSC Framework
  /// This avoids hard coding values
  /// </summary>
  public class PDSCConstants
  {
    /// <summary>
    /// The default name of the connection string in a .config file
    /// Value is: "FrameworkConnection"
    /// </summary>
    public const string FRAMEWORK_CONNECTION_STRING_NAME = "FrameworkConnection";
    /// <summary>
    /// The default name of the connection string in a .config file
    /// Value is: "ApplicationConnection"
    /// </summary>
    public const string APPLICATION_CONNECTION_STRING_NAME = "DefaultConnection";
    /// <summary>
    /// The default user login name
    /// Value is: "Unknown"
    /// </summary>
    public const string DEFAULT_LOGIN_NAME = "Unknown";
    /// <summary>
    /// The default language
    /// </summary>
    public const string DEFAULT_LANGUAGE = "en-us";
    /// <summary>
    /// Ascending Sort
    /// Value is: " ASC"
    /// </summary>
    public const string SORT_ASCENDING = " ASC";
    /// <summary>
    /// Descending Sort
    /// Value is: " DESC"
    /// </summary>
    public const string SORT_DESCENDING = " DESC";
    /// <summary>
    /// The default log name to publish to
    /// Value is: "Application"
    /// </summary>
    public const string EVENT_LOG_NAME = "Application";
    /// <summary>
    /// The default file name to publish to
    /// Value is: "[AppPath]\Exception.log"
    /// </summary>
    public const string EXCEPTION_FILE_PATH_NAME = @"[AppPath]\Exception.log";
    /// <summary>
    /// The default trace listener
    /// Value is: "CSTracer"
    /// </summary>
    public const string TRACE_LISTENER_NAME = "PDSCTracer";
    /// <summary>
    /// The default trace listener switch
    /// Value is: "PDSCTracerSwitch"
    /// </summary>
    public const string TRACE_LISTENER_SWITCH_NAME = "PDSCTracerSwitch";
  }
}
