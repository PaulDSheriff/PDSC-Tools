using System.ComponentModel.DataAnnotations;

namespace PDSC.Common.Shopping
{
  /// <summary>
  /// An entity class representing Credit Card information
  /// </summary>
  public partial class CreditCard
  {
    [Required]
    [StringLength(20)]
    [Display(Name = "Select Card Type")]
    public string CardType { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Name on Card")]
    public string NameOnCard { get; set; }

    [Required]
    [StringLength(25)]
    [Display(Name = "Credit Card Number")]
    [CreditCard]
    public string CardNumber { get; set; }

    [Required]
    [StringLength(4, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
    [Display(Name = "Code on Back")]
    public string SecurityCode { get; set; }

    [Display(Name = "Expiration Month")]
    [Range(minimum: 1, maximum: 12, ErrorMessage = "Month Must be Between 1 and 12")]
    public int ExpMonth { get; set; }

    [Display(Name = "Expiration Year")]
    public int ExpYear { get; set; }

    [Required]
    [StringLength(10)]
    [Display(Name = "Billing Postal Code")]
    public string BillingPostalCode { get; set; }
  }
}
