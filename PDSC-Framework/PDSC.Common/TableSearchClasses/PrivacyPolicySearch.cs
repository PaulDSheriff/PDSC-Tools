using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class PrivacyPolicySearch : SearchBase 
  {
    /// <summary>
    /// Get/Set the PrivacyText value
    /// </summary>
    [Display(Name = "Privacy Text")]
    public string PrivacyText { get; set; }
   
    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(PrivacyText)) {
        ret += comma + $"PrivacyText={PrivacyText}";
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
