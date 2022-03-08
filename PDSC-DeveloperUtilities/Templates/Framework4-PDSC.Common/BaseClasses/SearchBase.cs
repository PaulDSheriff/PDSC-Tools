using System;

namespace PDSC.Common
{
  /// <summary>
  /// All search classes should inherit from this class
  /// </summary>
  public class SearchBase
  {
    public SearchBase()
    {
      NoFilterAppliedMessage = "(none)";
    }

    /// <summary>
    /// Get/Set any message to display after user performs a search
    /// </summary>
    public string NoFilterAppliedMessage { get; set; }
  }
}
