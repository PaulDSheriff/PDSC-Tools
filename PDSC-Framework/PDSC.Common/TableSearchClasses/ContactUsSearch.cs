using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class ContactUsSearch : SearchBase 
  {
    /// <summary>
    /// Get/Set the FirstName value
    /// </summary>
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
   
    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(FirstName)) {
        ret += comma + $"FirstName={FirstName}";
        comma = ",";
      }
      if (string.IsNullOrEmpty(ret)) {
        ret = NoFilterAppliedMessage;
      }
      else {
        ret = $"{ret}";
      }

      return ret;
    }
    #endregion
  }
}
