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
    /// Get/Set the complete sort expression such as lastname_asc, firstname_desc, etc.
    /// </summary>
    public string SortExpression { get; set; }

    /// <summary>
    /// Get/Set any message to display after user performs a search
    /// </summary>
    public string NoFilterAppliedMessage { get; set; }        
  }
}
