#nullable disable

namespace PDSC.Common {
  /// <summary>
  /// A class that represents a pager object
  /// </summary>
  public class PDSCPager {
    #region Constructor
    /// <summary>
    /// Constructor for the Pager class
    /// </summary>
    public PDSCPager() {
      Init();
    }

    /// <summary>
    /// Constructor for Pager class
    /// </summary>
    /// <param name="pageSize">The page size to use</param>
    public PDSCPager(int pageSize) {
      Init();

      PageSize = pageSize;
    }

    /// <summary>
    /// Constructor for Pager class
    /// </summary>
    /// <param name="pageSize">The page size to use</param>
    /// <param name="visiblePagesToDisplay">The number of pagers to display</param>
    public PDSCPager(int pageSize, int visiblePagesToDisplay) {
      Init();

      PageSize = pageSize;
      VisiblePagesToDisplay = visiblePagesToDisplay;
    }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize this class
    /// </summary>
    public virtual void Init() {
      PageSize = 10;
      VisiblePagesToDisplay = 10;
      PageIndex = 0;
      StartingRow = 1;
      TotalPages = 0;
      TotalRecords = 0;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the page size selected
    /// </summary>
    private int _PageSize = 0;
    /// <summary>
    /// Get/Set the Page Size
    /// </summary>
    public int PageSize
    {
      get { return _PageSize; }
      set
      {
        _PageSize = value;
        CalculateTotalPages();
      }
    }
    /// <summary>
    /// Get/Set the Current Page Index
    /// </summary>
    public int PageIndex { get; set; }
    /// <summary>
    /// Get/set the row to start at
    /// </summary>
    public int StartingRow { get; set; }
    /// <summary>
    /// Get/Set total number of visible pages to display
    /// </summary>
    private int _VisiblePagesToDisplay;
    public int VisiblePagesToDisplay
    {
      get { return _VisiblePagesToDisplay; }
      set
      {
        _VisiblePagesToDisplay = value;
        if (_VisiblePagesToDisplay < 2) {
          _VisiblePagesToDisplay = 2;
        }
      }
    }
    /// <summary>
    /// Get/Set the total number of pages
    /// </summary>
    public int TotalPages { get; set; }

    private int _TotalRecords = 0;
    /// <summary>
    /// Get/Set the total records
    /// </summary>
    public int TotalRecords
    {
      get { return _TotalRecords; }
      set
      {
        _TotalRecords = value;
        CalculateTotalPages();
      }
    }
    #endregion

    #region CalculateTotalPages Method
    /// <summary>
    /// Calculate total number of pager items to create
    /// </summary>
    public void CalculateTotalPages() {
      if (PageSize > 0) {
        TotalPages = Convert.ToInt32(
                      Math.Ceiling(
                         Convert.ToDecimal(TotalRecords) /
                         Convert.ToDecimal(PageSize)));
      }
    }
    #endregion

    #region SetPagerProperties Method
    /// <summary>
    /// Set the properties of this class based on the command passed in.
    /// </summary>
    /// <param name="command">A command such as 'first', 'next', 'last', 'previous', or a page number</param>
    public virtual void SetPagerProperties(string command) {
      if (int.TryParse(command, out int page)) {
        this.PageIndex = page;
      }
      else {
        switch (command) {
          case PagerCommands.First:
            this.PageIndex = 0;
            break;

          case PagerCommands.Next:
            if (this.PageIndex < this.TotalPages) {
              this.PageIndex++;
            }
            break;

          case PagerCommands.Previous:
            if (this.PageIndex != 0) {
              this.PageIndex--;
            }
            break;

          case PagerCommands.Last:
            this.PageIndex = this.TotalPages - 1;
            break;
        }
      }

      StartingRow = (PageIndex * PageSize);
    }
    #endregion
  }

  /// <summary>
  /// Class to hold a collection of pager items to display on a page
  /// </summary>
  public class PagerItemCollection : List<PagerItem> {
    #region Constructor
    /// <summary>
    /// Constructor for the PagerItemCollection class
    /// </summary>
    /// <param name="pagerInfo">An instance of a Pager object</param>
    public PagerItemCollection(PDSCPager pagerInfo) {
      // Initialize the collection of pager items
      Init(pagerInfo);
    }
    #endregion

    #region Init Method
    private void Init(PDSCPager pagerInfo) {
      int itemIndex = 0;
      int start;
      int index;
      bool displayNextPager = false;

      Add(new PagerItem(PagerCommands.FirstText,
                        PagerCommands.First,
                        (pagerInfo.PageIndex == 0), PagerCommands.FirstTooltipText));
      itemIndex++;
      Add(new PagerItem(PagerCommands.PreviousText,
                        PagerCommands.Previous,
                        (pagerInfo.PageIndex == 0), PagerCommands.PreviousTooltipText));
      itemIndex++;

      if (pagerInfo.PageIndex >= pagerInfo.VisiblePagesToDisplay) {
        Add(new PagerItem(PagerCommands.PreviousPageText,
                          (pagerInfo.PageIndex - pagerInfo.VisiblePagesToDisplay).ToString(),
                          false, PagerCommands.PreviousPageTooltipText));
        itemIndex++;
      }

      // Figure out start page
      start = Convert.ToInt32(Math.Round(Convert.ToDecimal(pagerInfo.PageIndex / pagerInfo.VisiblePagesToDisplay), 0, MidpointRounding.AwayFromZero));
      start *= pagerInfo.VisiblePagesToDisplay;
      start = (start < 0 ? 0 : start);

      for (index = start; index < pagerInfo.TotalPages; index++) {
        Add(new PagerItem(index, pagerInfo.PageIndex,
                          PagerCommands.PageText + " " + (index + 1).ToString()));
        itemIndex++;
        if (index == (start + (pagerInfo.VisiblePagesToDisplay - 1))) {
          if ((index + 1) != pagerInfo.TotalPages) {
            displayNextPager = true;
          }
          break;
        }
      }
      if (displayNextPager) {
        Add(new PagerItem(PagerCommands.NextPageText,
                          (index + 1).ToString(),
                          false, PagerCommands.NextPageTooltipText));
      }

      Add(new PagerItem(PagerCommands.NextText,
                        PagerCommands.Next,
                        (pagerInfo.TotalPages - 1 == pagerInfo.PageIndex), PagerCommands.NextTooltipText));

      Add(new PagerItem(PagerCommands.LastText,
                        PagerCommands.Last,
                        (pagerInfo.TotalPages - 1 == pagerInfo.PageIndex), PagerCommands.LastTooltipText));
    }
    #endregion
  }

  /// <summary>
  /// This class represents a single pager item. Used to display a single pager item below a grid.
  /// </summary>
  public class PagerItem {
    #region Constructors
    /// <summary>
    /// Constructor for PagerItem
    /// </summary>
    /// <param name="pageCount">Total pages</param>
    /// <param name="pageIndex">Current page</param>
    /// <param name="tooltip">Tooltip to display on this page</param>
    public PagerItem(int pageCount, int pageIndex, string tooltip) {
      Init();

      Text = (pageCount + 1).ToString();
      Argument = pageCount.ToString();
      IsSelected = (pageCount == pageIndex);
      Tooltip = tooltip;
    }

    /// <summary>
    /// Constructor for PagerItem
    /// </summary>
    /// <param name="text">Text to display</param>
    /// <param name="arg">An argument to pass to server when clicked upon</param>
    /// <param name="isDisabled">Is disabled?</param>
    /// <param name="tooltip"></param>
    public PagerItem(string text, string arg, bool isDisabled, string tooltip) {
      Init();

      Text = text;
      Argument = arg;
      Tooltip = tooltip;
      IsDisabled = isDisabled;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the text to use for the pager
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Get/Set the tooltip to use for the pager
    /// </summary>
    public string Tooltip { get; set; }
    /// <summary>
    /// Get/Set the argument to use for the pager
    /// </summary>
    public string Argument { get; set; }
    /// <summary>
    /// Get/Set whether or not this pager is selected
    /// </summary>
    public bool IsSelected { get; set; }
    /// <summary>
    /// Get/Set whether or not this pager is disabled
    /// </summary>
    public bool IsDisabled { get; set; }
    /// <summary>
    /// Get/Set the css class for a selected pager. Default is 'active'.
    /// </summary>
    public string CssActiveClass { get; set; }
    /// <summary>
    /// Get/Set the css class for a disabled pager. Default is 'disabled'.
    /// </summary>
    public string CssDisabledClass { get; set; }
    /// <summary>
    /// Get/Set the CSS Class to apply based on the IsSelected/IsDisabled properties.
    /// </summary>
    public string CssClass
    {
      get
      {
        string result = string.Empty;
        if (IsSelected) {
          result = CssActiveClass;
        }
        else if (IsDisabled) {
          result = CssDisabledClass;
        }
        return result;
      }
    }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize this class
    /// </summary>
    public virtual void Init() {
      Text = string.Empty;
      Argument = string.Empty;
      Tooltip = string.Empty;
      CssActiveClass = "active";
      CssDisabledClass = "disabled";
      IsSelected = false;
      IsDisabled = false;
    }
    #endregion

    #region ToString Override
    /// <summary>
    /// Override of ToString
    /// </summary>
    /// <returns>Text property</returns>
    public override string ToString() {
      return Text;
    }
    #endregion
  }

  /// <summary>
  /// This class contains Pager commands for moving through a pager.
  /// It also contains the Text for displaying pager information.
  /// </summary>
  public class PagerCommands {
    /// <summary>
    /// Static constructor for PagerCommands class
    /// </summary>
    static PagerCommands() {
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
