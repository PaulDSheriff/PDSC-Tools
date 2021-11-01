using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.ContactUs table.
  /// </summary>
  
  [Table("ContactUs", Schema = "Lookup")]
  public partial class ContactUs : TableEntityBase
  {
    #region Constructor
    public ContactUs() {
    }
    #endregion

    /// <summary>
    /// Get/Set the ContactUsId value
    /// </summary>
    [Display(Name = "Contact Us Id")]
    [Key]
    public int? ContactUsId { get; set; }

    /// <summary>
    /// Get/Set the FirstName value
    /// </summary>
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "First Name must be between {2} and {1} characters long.")]
    public string FirstName { get; set; }

    /// <summary>
    /// Get/Set the LastName value
    /// </summary>
    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name must be filled in.")]
    [StringLength(75, MinimumLength=1, ErrorMessage = "Last Name must be between {2} and {1} characters long.")]
    public string LastName { get; set; }

    /// <summary>
    /// Get/Set the EmailAddress value
    /// </summary>
    [Display(Name = "Email Address")]
    [Required(ErrorMessage = "Email Address must be filled in.")]
    [StringLength(255, MinimumLength=1, ErrorMessage = "Email Address must be between {2} and {1} characters long.")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Get/Set the Phone value
    /// </summary>
    [Display(Name = "Phone")]
    [StringLength(50, MinimumLength=0, ErrorMessage = "Phone must be between {2} and {1} characters long.")]
    public string Phone { get; set; }

    /// <summary>
    /// Get/Set the ContactText value
    /// </summary>
    [Display(Name = "Contact Text")]
    [Required(ErrorMessage = "Contact Text must be filled in.")]
    [StringLength(1073741823, MinimumLength=1, ErrorMessage = "Contact Text must be between {2} and {1} characters long.")]
    public string ContactText { get; set; }

    /// <summary>
    /// Get/Set the IPAddress value
    /// </summary>
    [Display(Name = "IP Address")]
    [StringLength(150, MinimumLength=0, ErrorMessage = "IP Address must be between {2} and {1} characters long.")]
    public string IPAddress { get; set; }

    /// <summary>
    /// Get/Set the RespondedByName value
    /// </summary>
    [Display(Name = "Responded By Name")]
    [StringLength(50, MinimumLength=0, ErrorMessage = "Responded By Name must be between {2} and {1} characters long.")]
    public string RespondedByName { get; set; }

    /// <summary>
    /// Get/Set the RespondedDate value
    /// </summary>
    [Display(Name = "Responded Date")]
    [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Responded Date must be between {1} and {2}")]
    public DateTime? RespondedDate { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{FirstName}";
    }
    #endregion
  }
}
