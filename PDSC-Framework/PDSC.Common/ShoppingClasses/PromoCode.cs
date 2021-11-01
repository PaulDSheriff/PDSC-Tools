using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.Shopping
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.PromoCode table.
  /// </summary>
  [Table("PromoCode", Schema = "Lookup")]
  public partial class PromoCode : TableEntityBase
  {
    public PromoCode()
    {
    }

    /// <summary>
    /// Get/Set the PromoCodeId value
    /// </summary>
    [Display(Name = "Promo Code Id")]
    [Key]
    public int? PromoCodeId { get; set; }

    /// <summary>
    /// Get/Set the PromotionalCode value
    /// </summary>
    [Display(Name = "Promotional Code")]
    [Required(ErrorMessage = "Promotional Code must be filled in.")]
    [StringLength(20, MinimumLength = 1, ErrorMessage = "Promotional Code must be between {2} and {1} characters long.")]
    public string PromotionalCode { get; set; }

    /// <summary>
    /// Get/Set the DiscountPercent value
    /// </summary>
    [Display(Name = "Discount Percent")]
    [DisplayFormat(DataFormatString = "{0:P0}")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal DiscountPercent { get; set; }

    /// <summary>
    /// Get/Set the StartDate value
    /// </summary>
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Any Time")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Get/Set the EndDate value
    /// </summary>
    [Display(Name = "End Date")]
    [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Any Time")]
    public DateTime? EndDate { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{PromotionalCode}";
    }
    #endregion
  }
}
