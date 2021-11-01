using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.CanadianProvince table.
  /// </summary>
  
  [Table("CanadianProvince", Schema = "Lookup")]
  public partial class CanadianProvince : TableEntityBaseStringPK 
  {
    #region Constructor
    public CanadianProvince() {
    }
    #endregion

    /// <summary>
    /// Get/Set the ProvinceCode value
    /// </summary>
    [Display(Name = "Province Code")]
    [Required(ErrorMessage = "Province Code must be filled in.")]
    [Key]
    [StringLength(2, MinimumLength=1, ErrorMessage = "Province Code must be between {2} and {1} characters long.")]
    public string ProvinceCode { get; set; }

    /// <summary>
    /// Get/Set the ProvinceName value
    /// </summary>
    [Display(Name = "Province Name")]
    [Required(ErrorMessage = "Province Name must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "Province Name must be between {2} and {1} characters long.")]
    public string ProvinceName { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{ProvinceName}";
    }
    #endregion
  }
}
