using System;
using System.ComponentModel.DataAnnotations;
using PDSCFramework.Common;

namespace PDSCFramework.EntityLayer
{
  /// <summary>
  /// This class contains properties to help with searching
  /// </summary>
  public partial class PersonSearch : AppSearchBase 
  {
    /// <summary>
    /// Get/Set the FirstName value
    /// </summary>
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    /// <summary>
    /// Get/Set the LastName value
    /// </summary>
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    /// <summary>
    /// Get/Set the EmailAddress value
    /// </summary>
    [Display(Name = "Email Address")]
    public string EmailAddress { get; set; }

    #region ToString Override
    public override string ToString()
    {
      string ret = string.Empty;
      string comma = string.Empty;

      if (!string.IsNullOrEmpty(FirstName)) {
        ret += comma + $"FirstName={FirstName}";
        comma = ",";
      }
      if (!string.IsNullOrEmpty(LastName)) {
        ret += comma + $"LastName={LastName}";
        comma = ",";
      }
      if (!string.IsNullOrEmpty(EmailAddress)) {
        ret += comma + $"EmailAddress={EmailAddress}";
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
