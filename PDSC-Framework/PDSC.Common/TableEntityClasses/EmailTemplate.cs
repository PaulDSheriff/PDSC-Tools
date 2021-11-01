using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.EmailTemplate table.
  /// </summary>
  
  [Table("EmailTemplate", Schema = "Lookup")]
  public partial class EmailTemplate : TableEntityBase
  {
    #region Constructor
    public EmailTemplate() {
    }
    #endregion

    /// <summary>
    /// Get/Set the EmailTemplateId value
    /// </summary>
    [Display(Name = "Email Template Id")]
    [Key]
    public int? EmailTemplateId { get; set; }

    /// <summary>
    /// Get/Set the EmailTemplateName value
    /// </summary>
    [Display(Name = "Email Template Name")]
    [Required(ErrorMessage = "Email Template Name must be filled in.")]
    [StringLength(30, MinimumLength=1, ErrorMessage = "Email Template Name must be between {2} and {1} characters long.")]
    public string EmailTemplateName { get; set; }

    /// <summary>
    /// Get/Set the EmailSubject value
    /// </summary>
    [Display(Name = "Email Subject")]
    [Required(ErrorMessage = "Email Subject must be filled in.")]
    [StringLength(100, MinimumLength=1, ErrorMessage = "Email Subject must be between {2} and {1} characters long.")]
    public string EmailSubject { get; set; }

    /// <summary>
    /// Get/Set the EmailTemplateText value
    /// </summary>
    [Display(Name = "Email Template Text")]
    [Required(ErrorMessage = "Email Template Text must be filled in.")]
    [StringLength(1073741823, MinimumLength=1, ErrorMessage = "Email Template Text must be between {2} and {1} characters long.")]
    public string EmailTemplateText { get; set; }

    /// <summary>
    /// Get/Set the IsBodyHtml value
    /// </summary>
    [Display(Name = "Is Body Html")]
    public bool IsBodyHtml { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{EmailTemplateName}";
    }
    #endregion
  }
}
