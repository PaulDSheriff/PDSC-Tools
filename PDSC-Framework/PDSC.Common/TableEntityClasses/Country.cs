using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.Country table.
  /// </summary>

  [Table("Country", Schema = "Lookup")]
  public partial class Country : TableEntityBaseStringPK
  {
    #region Constructor
    public Country() {
    }
    #endregion

    /// <summary>
    /// Get/Set the CountryCode value
    /// </summary>
    [Display(Name = "Country Code")]
    [Required(ErrorMessage = "Country Code must be filled in.")]
    [Key]
    [StringLength(3, MinimumLength=1, ErrorMessage = "Country Code must be between {2} and {1} characters long.")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Get/Set the CountryName value
    /// </summary>
    [Display(Name = "Country Name")]
    [Required(ErrorMessage = "Country Name must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "Country Name must be between {2} and {1} characters long.")]
    public string CountryName { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{CountryName}";
    }
    #endregion
  }
}
