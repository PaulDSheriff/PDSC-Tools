using System;

namespace PDSC.Common
{
  /// <summary>
  /// Enumeration of the type of special folder names used in method ExpandSpecialFolders.
  /// </summary>
  public enum SpecialFolderNameTypes
  {
    /// <summary>
    /// Expands to the path where the .EXE is running
    /// </summary>
    AppPath,
    /// <summary>
    /// Expands to the user's application data path
    /// </summary>
    UserAppData,
    /// <summary>
    /// Expands to the user's MyDocuments path
    /// </summary>
    MyDocuments,
    /// <summary>
    /// Expands to the folder where the PDSC Framework is located
    /// </summary>
    FrameworkPath,
    /// <summary>
    /// Expands to the folder where the PDSC Framework User Data is located
    /// </summary>
    FrameworkUserPath,
    /// <summary>
    /// Expands to the configuration file for the current .EXE
    /// </summary>
    ConfigFile
  }
}
