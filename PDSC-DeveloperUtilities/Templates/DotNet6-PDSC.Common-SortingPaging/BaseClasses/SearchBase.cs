#nullable disable

using System.Text.Json.Serialization;

namespace PDSC.Common
{
  /// <summary>
  /// All search classes should inherit from this class
  /// </summary>
  public class SearchBase
  {
    public SearchBase()
    {
      PageIndex = 0;
      PageSize = 10;
      NoFilterAppliedMessage = "(none)";
    }

    /// <summary>
    /// Get/Set the Page number the user is on
    /// </summary>
    public int PageIndex { get; set; }
    /// <summary>
    /// Get/Set the Number of Record per page
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// Get/Set the complete sort expression such as lastname_asc, firstname_desc, etc.
    /// </summary>
    public string SortExpression { get; set; }

    /// <summary>
    /// Get/Set any message to display after user performs a search
    /// </summary>
    [JsonIgnore]
    public string NoFilterAppliedMessage { get; set; }
  }
}
