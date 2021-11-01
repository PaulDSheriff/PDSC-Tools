using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.PersonType table.
  /// </summary>
  
  [Table("PersonType", Schema = "Lookup")]
  public partial class PersonType : TableEntityBase
  {
    #region Constructor
    public PersonType() {
    }
    #endregion

    /// <summary>
    /// Get/Set the PersonTypeId value
    /// </summary>
    [Display(Name = "Person Type Id")]
    [Key]
    public int? PersonTypeId { get; set; }

    /// <summary>
    /// Get/Set the TypeDescription value
    /// </summary>
    [Display(Name = "Type Description")]
    [Required(ErrorMessage = "Type Description must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "Type Description must be between {2} and {1} characters long.")]
    public string TypeDescription { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{TypeDescription}";
    }
    #endregion
  }
}
