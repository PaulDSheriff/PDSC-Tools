namespace PDSC.Common
{
  /// <summary>
  /// Enumeration for the type of log entry to write
  /// </summary>
  public enum LoggingTypeEnum
  {
    /// <summary>
    /// Information log entry
    /// </summary>
    Info,
    /// <summary>
    /// Warning log entry
    /// </summary>
    Warning,
    /// <summary>
    /// Debugging log entry
    /// </summary>
    Debug,
    /// <summary>
    /// Insert audit trail log entry
    /// </summary>
    AuditInsert,
    /// <summary>
    /// Update audit trail log entry
    /// </summary>
    AuditUpdate,
    /// <summary>
    /// Delete audit trail log entry
    /// </summary>
    AuditDelete,
  }
}
