using System;

namespace PDSC.PagerClasses
{
  /// <summary>
  /// A class that represents a pager object
  /// </summary>
  public class Pager
  {
    #region Constructor
    /// <summary>
    /// Constructor for the Pager class
    /// </summary>
    public Pager()
    {
      Init();
    }

    /// <summary>
    /// Constructor for Pager class
    /// </summary>
    /// <param name="pageSize">The page size to use</param>
    public Pager(int pageSize)
    {
      Init();

      PageSize = pageSize;
    }

    /// <summary>
    /// Constructor for Pager class
    /// </summary>
    /// <param name="pageSize">The page size to use</param>
    /// <param name="visiblePagesToDisplay">The number of pagers to display</param>
    public Pager(int pageSize, int visiblePagesToDisplay)
    {
      Init();

      PageSize = pageSize;
      VisiblePagesToDisplay = visiblePagesToDisplay;
    }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize this class
    /// </summary>
    public virtual void Init()
    {
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
        if (_VisiblePagesToDisplay < 2)
        {
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
    public void CalculateTotalPages()
    {
      if (PageSize > 0)
      {
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
    public virtual void SetPagerProperties(string command)
    {
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
}
