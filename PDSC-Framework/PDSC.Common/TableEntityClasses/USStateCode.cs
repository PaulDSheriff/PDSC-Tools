using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.USStateCode table.
  /// </summary>
  
  [Table("USStateCode", Schema = "Lookup")]
  public partial class USStateCode : TableEntityBaseStringPK 
  {
    #region Constructor
    public USStateCode() {
    }
    #endregion

    /// <summary>
    /// Get/Set the StateCode value
    /// </summary>
    [Display(Name = "State Code")]
    [Required(ErrorMessage = "State Code must be filled in.")]
    [Key]
    [StringLength(2, MinimumLength=1, ErrorMessage = "State Code must be between {2} and {1} characters long.")]
    public string StateCode { get; set; }

    /// <summary>
    /// Get/Set the StateName value
    /// </summary>
    [Display(Name = "State Name")]
    [Required(ErrorMessage = "State Name must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "State Name must be between {2} and {1} characters long.")]
    public string StateName { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{StateName}";
    }
    #endregion
  }
}
