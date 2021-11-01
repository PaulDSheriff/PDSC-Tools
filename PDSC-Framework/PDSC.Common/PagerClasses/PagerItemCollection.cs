using System;
using System.Collections.Generic;

namespace PDSC.PagerClasses
{
  /// <summary>
  /// Class to hold a collection of pager items to display on a page
  /// </summary>
  public class PagerItemCollection : List<PagerItem>
  {
    #region Constructor
    /// <summary>
    /// Constructor for the PagerItemCollection class
    /// </summary>
    /// <param name="pagerInfo">An instance of a Pager object</param>
    public PagerItemCollection(Pager pagerInfo)
    {
      // Initialize the collection of pager items
      Init(pagerInfo);
    }
    #endregion

    #region Init Method
    private void Init(Pager pagerInfo)
    {
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
}
