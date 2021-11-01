using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class EmailTemplateSearch : SearchBase 
  {
    /// <summary>
    /// Get/Set the EmailTemplateName value
    /// </summary>
    [Display(Name = "Email Template Name")]
    public string EmailTemplateName { get; set; }
   
    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(EmailTemplateName)) {
        ret += comma + $"EmailTemplateName={EmailTemplateName}";
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
