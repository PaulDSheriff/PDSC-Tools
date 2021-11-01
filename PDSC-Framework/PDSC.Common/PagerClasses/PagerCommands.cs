
namespace PDSC.PagerClasses
{
  /// <summary>
  /// This class contains Pager commands for moving through a pager.
  /// It also contains the Text for displaying pager information.
  /// </summary>
  public class PagerCommands
  {
    /// <summary>
    /// Static constructor for PagerCommands class
    /// </summary>
    static PagerCommands()
    {
      FirstTooltipText = "First Page";
      NextTooltipText = "Next Page";
      NextPageTooltipText = "Next Pages";
      PreviousTooltipText = "Previous Page";
      PreviousPageTooltipText = "Previous Pages";
      LastTooltipText = "Last Page";

      FirstText = "&laquo;";
      NextText = "&rsaquo;";
      NextPageText = "...";
      PreviousText = "&lsaquo;";
      PreviousPageText = "...";
      LastText = "&raquo;";

      PageText = "Page";
    }

    /// <summary>
    /// "first"
    /// </summary>
    public const string First = "first";
    /// <summary>
    /// "next"
    /// </summary>
    public const string Next = "next";
    /// <summary>
    /// "nextPage"
    /// </summary>
    public const string NextPage = "next";
    /// <summary>
    /// "prev"
    /// </summary>
    public const string Previous = "prev";
    /// <summary>
    /// "prevPage"
    /// </summary>
    public const string PreviousPage = "prev";
    /// <summary>
    /// "last"
    /// </summary>
    public const string Last = "last";

    /// <summary>
    /// Get/Set the first page tooltip text
    /// </summary>
    public static string FirstTooltipText { get; set; }
    /// <summary>
    /// Get/Set the next tooltip text
    /// </summary>
    public static string NextTooltipText { get; set; }
    /// <summary>
    /// Get/Set the next page tooltip text
    /// </summary>
    public static string NextPageTooltipText { get; set; }
    /// <summary>
    /// Get/Set the previous tooltip text
    /// </summary>
    public static string PreviousTooltipText { get; set; }
    /// <summary>
    /// Get/Set the previous page tooltip text
    /// </summary>
    public static string PreviousPageTooltipText { get; set; }
    /// <summary>
    /// Get/Set the last page tooltip text
    /// </summary>
    public static string LastTooltipText { get; set; }

    /// <summary>
    /// Get/Set the first page text
    /// </summary>
    public static string FirstText { get; set; }
    /// <summary>
    /// Get/Set the next text
    /// </summary>
    public static string NextText { get; set; }
    /// <summary>
    /// Get/Set the next page text
    /// </summary>
    public static string NextPageText { get; set; }
    /// <summary>
    /// Get/Set the previous text
    /// </summary>
    public static string PreviousText { get; set; }
    /// <summary>
    /// Get/Set the previous page text
    /// </summary>
    public static string PreviousPageText { get; set; }
    /// <summary>
    /// Get/Set the last page text
    /// </summary>
    public static string LastText { get; set; }

    /// <summary>
    /// Get/Set the page text
    /// </summary>
    public static string PageText { get; set; }
  }
}
