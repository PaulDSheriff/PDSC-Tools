using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.PrivacyPolicy table.
  /// </summary>
  
  [Table("PrivacyPolicy", Schema = "Lookup")]
  public partial class PrivacyPolicy : TableEntityBase
  {
    #region Constructor
    public PrivacyPolicy() {
    }
    #endregion

    /// <summary>
    /// Get/Set the PrivacyPolicyId value
    /// </summary>
    [Display(Name = "Privacy Policy Id")]
    [Key]
    public int? PrivacyPolicyId { get; set; }

    /// <summary>
    /// Get/Set the PrivacyText value
    /// </summary>
    [Display(Name = "Privacy Text")]
    [Required(ErrorMessage = "Privacy Text must be filled in.")]
    [StringLength(1073741823, MinimumLength=1, ErrorMessage = "Privacy Text must be between {2} and {1} characters long.")]
    public string PrivacyText { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{PrivacyText}";
    }
    #endregion
  }
}
