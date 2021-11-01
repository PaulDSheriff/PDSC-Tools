using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class CanadianProvinceSearch : SearchBase 
  {
    /// <summary>
    /// Get/Set the ProvinceName value
    /// </summary>
    [Display(Name = "Province Name")]
    public string ProvinceName { get; set; }
   
    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(ProvinceName)) {
        ret += comma + $"ProvinceName={ProvinceName}";
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
