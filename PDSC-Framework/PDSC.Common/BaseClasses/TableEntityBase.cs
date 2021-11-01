using System;
using System.ComponentModel.DataAnnotations;

namespace PDSC.Common
{
  /// <summary>
  /// All entity classes with a 'int' primary key should inherit from this base class
  /// </summary>
  public class TableEntityBase : EntityBase
  {
    #region Properties
    /// <summary>
    /// Get/Set the InsertName value
    /// </summary>
    [Display(Description = "Insert Name")]
    [Required(ErrorMessage = "Insert Name must be filled in.")]

    public string InsertName { get; set; }

    /// <summary>
    /// Get/Set the InsertDate value
    /// </summary>
    [Display(Description = "Insert Date")]
    [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Insert Date must be between {1} and {2}")]

    public DateTime InsertDate { get; set; }

    /// <summary>
    /// Get/Set the UpdateName value
    /// </summary>
    [Display(Description = "Update Name")]
    [Required(ErrorMessage = "Update Name must be filled in.")]

    public string UpdateName { get; set; }

    /// <summary>
    /// Get/Set the UpdateDate value
    /// </summary>
    [Display(Description = "Update Date")]
    [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Update Date must be between {1} and {2}")]

    public DateTime UpdateDate { get; set; }
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();

      InsertName = "info@yoursite.com";
      InsertDate = DateTime.Now;
      UpdateName = "info@yoursite.com";
      UpdateDate = DateTime.Now;
    }
    #endregion

    #region ShortenString Method
    /// <summary>
    /// Use this method to shorten description fields that might have a large amount of text in them.
    /// This is useful for displaying just a portion of the data in an HTML table.
    /// </summary>
    /// <param name="value">The string value</param>
    /// <param name="maxLength">The max length to cut the string to</param>
    /// <returns></returns>
    public string ShortenString(string value, int maxLength = 50)
    {
      if (!string.IsNullOrEmpty(value)) {
        if(value.Length > maxLength) {
          return value.Substring(0, maxLength);
        }
      }

      return value;
    }
    #endregion
  }
}
