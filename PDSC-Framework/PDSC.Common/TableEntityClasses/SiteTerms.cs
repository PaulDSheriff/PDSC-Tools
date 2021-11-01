using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.SiteTerms table.
  /// </summary>
  
  [Table("SiteTerms", Schema = "Lookup")]
  public partial class SiteTerms : TableEntityBase
  {
    #region Constructor
    public SiteTerms() {
    }
    #endregion

    /// <summary>
    /// Get/Set the SiteTermsId value
    /// </summary>
    [Display(Name = "Site Terms Id")]
    [Key]
    public int? SiteTermsId { get; set; }

    /// <summary>
    /// Get/Set the TermsText value
    /// </summary>
    [Display(Name = "Terms Text")]
    [Required(ErrorMessage = "Terms Text must be filled in.")]
    [StringLength(1073741823, MinimumLength=1, ErrorMessage = "Terms Text must be between {2} and {1} characters long.")]
    public string TermsText { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{TermsText}";
    }
    #endregion
  }
}
