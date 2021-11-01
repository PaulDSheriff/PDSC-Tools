
namespace PDSC.PagerClasses
{
  /// <summary>
  /// This class represents a single pager item. Used to display a single pager item below a grid.
  /// </summary>
  public class PagerItem
  {
    #region Constructors
    /// <summary>
    /// Constructor for PagerItem
    /// </summary>
    /// <param name="pageCount">Total pages</param>
    /// <param name="pageIndex">Current page</param>
    /// <param name="tooltip">Tooltip to display on this page</param>
    public PagerItem(int pageCount, int pageIndex, string tooltip)
    {
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
    public PagerItem(string text, string arg, bool isDisabled, string tooltip)
    {
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
        if (IsSelected)
        {
          result = CssActiveClass;
        }
        else if (IsDisabled)
        {
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
    public virtual void Init()
    {
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
    public override string ToString()
    {
      return Text;
    }
    #endregion
  }
}
