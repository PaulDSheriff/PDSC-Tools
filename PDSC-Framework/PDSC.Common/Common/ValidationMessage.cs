using System;

namespace PDSC.Common
{
  /// <summary>
  /// This class holds a property and a message for validation exceptions
  /// </summary>
  public class ValidationMessage
  {
    #region Constructors
    public ValidationMessage()
    {
    }

    public ValidationMessage(string propName, string msg)
    {
      PropertyName = propName;
      Message = msg;
    }
    #endregion

    /// <summary>
    /// Get/Set the property/field name with validation error
    /// </summary>
    public string PropertyName { get; set; }
    /// <summary>
    /// Get/Set the validation message
    /// </summary>
    public string Message { get; set; }
  }
}
