using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class PersonTypeSearch :SearchBase 
  {
    /// <summary>
    /// Get/Set the TypeDescription value
    /// </summary>
    [Display(Name = "Type Description")]
    public string TypeDescription { get; set; }
   
    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(TypeDescription)) {
        ret += comma + $"TypeDescription={TypeDescription}";
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
