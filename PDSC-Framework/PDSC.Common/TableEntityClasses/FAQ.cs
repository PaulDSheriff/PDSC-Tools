using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.FAQ table.
  /// </summary>
  
  [Table("FAQ", Schema = "Lookup")]
  public partial class FAQ : TableEntityBase
  {
    #region Constructor
    public FAQ() {
    }
    #endregion

    /// <summary>
    /// Get/Set the FAQId value
    /// </summary>
    [Display(Name = "FAQ Id")]
    [Key]
    public int? FAQId { get; set; }

    /// <summary>
    /// Get/Set the FAQQuestion value
    /// </summary>
    [Display(Name = "FAQ Question")]
    [Required(ErrorMessage = "FAQ Question must be filled in.")]
    [StringLength(500, MinimumLength=1, ErrorMessage = "FAQ Question must be between {2} and {1} characters long.")]
    public string FAQQuestion { get; set; }

    /// <summary>
    /// Get/Set the FAQAnswer value
    /// </summary>
    [Display(Name = "FAQ Answer")]
    [Required(ErrorMessage = "FAQ Answer must be filled in.")]
    [StringLength(500, MinimumLength=1, ErrorMessage = "FAQ Answer must be between {2} and {1} characters long.")]
    public string FAQAnswer { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{FAQQuestion}";
    }
    #endregion
  }
}
