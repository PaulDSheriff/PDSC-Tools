using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PDSCFramework.Common;

namespace PDSCFramework.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the dbo.Person table.
  /// </summary>
  
  [Table("Person", Schema = "dbo")]
  public partial class Person : AppTableEntityBase
  {
    #region Constructor
    public Person() {
    }
    #endregion

    /// <summary>
    /// Get/Set the PersonId value
    /// </summary>
    [Display(Name = "Person Id")]
    [Key]
    public int? PersonId { get; set; }

    /// <summary>
    /// Get/Set the AspNetUsersId value
    /// </summary>
    [Display(Name = "Asp Net Users Id")]
    [StringLength(450, MinimumLength=0, ErrorMessage = "Asp Net Users Id must be between {2} and {1} characters long.")]
    public string AspNetUsersId { get; set; }

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
    /// Get/Set the HomePhone value
    /// </summary>
    [Display(Name = "Home Phone")]
    [StringLength(50, MinimumLength=0, ErrorMessage = "Home Phone must be between {2} and {1} characters long.")]
    public string HomePhone { get; set; }

    /// <summary>
    /// Get/Set the CellPhone value
    /// </summary>
    [Display(Name = "Cell Phone")]
    [Required(ErrorMessage = "Cell Phone must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "Cell Phone must be between {2} and {1} characters long.")]
    public string CellPhone { get; set; }

    /// <summary>
    /// Get/Set the Street1 value
    /// </summary>
    [Display(Name = "Street 1")]
    [Required(ErrorMessage = "Street 1 must be filled in.")]
    [StringLength(255, MinimumLength=1, ErrorMessage = "Street 1 must be between {2} and {1} characters long.")]
    public string Street1 { get; set; }

    /// <summary>
    /// Get/Set the Street2 value
    /// </summary>
    [Display(Name = "Street 2")]
    [StringLength(255, MinimumLength=0, ErrorMessage = "Street 2 must be between {2} and {1} characters long.")]
    public string Street2 { get; set; }

    /// <summary>
    /// Get/Set the Street3 value
    /// </summary>
    [Display(Name = "Street 3")]
    [StringLength(255, MinimumLength=0, ErrorMessage = "Street 3 must be between {2} and {1} characters long.")]
    public string Street3 { get; set; }

    /// <summary>
    /// Get/Set the City value
    /// </summary>
    [Display(Name = "City")]
    [Required(ErrorMessage = "City must be filled in.")]
    [StringLength(100, MinimumLength=1, ErrorMessage = "City must be between {2} and {1} characters long.")]
    public string City { get; set; }

    /// <summary>
    /// Get/Set the Village value
    /// </summary>
    [Display(Name = "Village")]
    [StringLength(100, MinimumLength=0, ErrorMessage = "Village must be between {2} and {1} characters long.")]
    public string Village { get; set; }

    /// <summary>
    /// Get/Set the StateCode value
    /// </summary>
    [Display(Name = "State Code")]
    [StringLength(2, MinimumLength=0, ErrorMessage = "State Code must be between {2} and {1} characters long.")]
    public string StateCode { get; set; }

    /// <summary>
    /// Get/Set the ProvinceCode value
    /// </summary>
    [Display(Name = "Province Code")]
    [StringLength(2, MinimumLength=0, ErrorMessage = "Province Code must be between {2} and {1} characters long.")]
    public string ProvinceCode { get; set; }

    /// <summary>
    /// Get/Set the PostalCode value
    /// </summary>
    [Display(Name = "Postal Code")]
    [Required(ErrorMessage = "Postal Code must be filled in.")]
    [StringLength(50, MinimumLength=1, ErrorMessage = "Postal Code must be between {2} and {1} characters long.")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Get/Set the CountryCode value
    /// </summary>
    [Display(Name = "Country Code")]
    [Required(ErrorMessage = "Country Code must be filled in.")]
    [StringLength(3, MinimumLength=1, ErrorMessage = "Country Code must be between {2} and {1} characters long.")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Get/Set the SiteTermsId value
    /// </summary>
    [Display(Name = "Site Terms Id")]
    public int? SiteTermsId { get; set; }

    /// <summary>
    /// Get/Set the DateTermsAccepted value
    /// </summary>
    [Display(Name = "Date Terms Accepted")]
    [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Date Terms Accepted must be between {1} and {2}")]
    public DateTime? DateTermsAccepted { get; set; }

    /// <summary>
    /// Get/Set the IsActive value
    /// </summary>
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// Get/Set the OkToSendEmails value
    /// </summary>
    [Display(Name = "Ok To Send Emails")]
    public bool OkToSendEmails { get; set; }

    /// <summary>
    /// Get/Set the PersonTypeId value
    /// </summary>
    [Display(Name = "Person Type Id")]
    public int? PersonTypeId { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{LastName}, {FirstName}";
    }
    #endregion
  }
}
