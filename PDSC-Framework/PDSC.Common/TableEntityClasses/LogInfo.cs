using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common.EntityLayer
{
  /// <summary>
  /// This class contains properties that map to each field in the Lookup.LogInfo table.
  /// </summary>
  
  [Table("LogInfo", Schema = "Lookup")]
  public partial class LogInfo : TableEntityBaseNoStdFields
  {
    #region Constructor
    public LogInfo() {
    }
    #endregion

    /// <summary>
    /// Get/Set the Id value
    /// </summary>
    [Display(Name = "Id")]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Get/Set the Message value
    /// </summary>
    [Display(Name = "Message")]
    [StringLength(1073741823, MinimumLength=0, ErrorMessage = "Message must be between {2} and {1} characters long.")]
    public string Message { get; set; }

    /// <summary>
    /// Get/Set the MessageTemplate value
    /// </summary>
    [Display(Name = "Message Template")]
    [StringLength(1073741823, MinimumLength=0, ErrorMessage = "Message Template must be between {2} and {1} characters long.")]
    public string MessageTemplate { get; set; }

    /// <summary>
    /// Get/Set the Level value
    /// </summary>
    [Display(Name = "Level")]
    [StringLength(128, MinimumLength=0, ErrorMessage = "Level must be between {2} and {1} characters long.")]
    public string Level { get; set; }

    /// <summary>
    /// Get/Set the TimeStamp value
    /// </summary>
    [Display(Name = "Time Stamp")]
    [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Time Stamp must be between {1} and {2}")]
    public DateTime? TimeStamp { get; set; }

    /// <summary>
    /// Get/Set the Exception value
    /// </summary>
    [Display(Name = "Exception")]
    [StringLength(1073741823, MinimumLength=0, ErrorMessage = "Exception must be between {2} and {1} characters long.")]
    public string Exception { get; set; }

    /// <summary>
    /// Get/Set the Properties value
    /// </summary>
    [Display(Name = "Properties")]
    [StringLength(1073741823, MinimumLength=0, ErrorMessage = "Properties must be between {2} and {1} characters long.")]
    public string Properties { get; set; }

    #region ToString Override
    public override string ToString()
    {
      return $"{Message}";
    }
    #endregion
  }
}
