using System.Text;

namespace PDSC.Common;

public class PDSCException : Exception {
  #region Constructors
  public PDSCException() : base() {
  }

  public PDSCException(string message) : base(message) {
  }

  public PDSCException(string message, Exception innerException) : base(message, innerException) {
  }
  #endregion

  #region Public Properties
  public string StackTraceListing { get; set; } = string.Empty;
  public bool IsDataException { get; set; }
  public int? Errorcode { get; set; }
  public int? SqlNumber { get; set; }
  public int? SqlClass { get; set; }
  public int? SqlLineNumber { get; set; }
  public string SqlProcedure { get; set; } = string.Empty;
  public string SqlServer { get; set; } = string.Empty;
  public string AllSqlExceptionData { get; set; } = string.Empty;
  public string SqlQuery { get; set; } = string.Empty;
  public string SqlSource { get; set; } = string.Empty;
  public string ConnectionString { get; set; } = string.Empty;
  public string DatabaseName { get; set; } = string.Empty;
  public string WorkstationId { get; set; } = string.Empty;
  #endregion

  #region Override of ToString()
  public override string ToString() {
    StringBuilder sb = new(2048);

    sb.AppendLine($"*** Exception Occurred at: {DateTime.Now} on Machine: {Environment.MachineName} ***");
    sb.AppendLine($"Message: {Message}");
    sb.AppendLine($"Source: {Source}");
    if (IsDataException) {
      sb.AppendLine($"  *** SQL Exception Information ***");
      if (!string.IsNullOrEmpty(SqlServer)) {
        sb.AppendLine($"  SQL Server: {SqlServer}");
      }
      if (!string.IsNullOrEmpty(DatabaseName)) {
        sb.AppendLine($"  SQL Database: {DatabaseName}");
      }
      if (!string.IsNullOrEmpty(SqlQuery)) {
        sb.AppendLine($"  SQL Query: {SqlQuery}");
      }
      if (SqlNumber.HasValue) {
        sb.AppendLine($"  SQL Number: {SqlNumber}");
      }
      if (SqlClass.HasValue) {
        sb.AppendLine($"  SQL Class:{SqlClass}");
      }
      if (!string.IsNullOrEmpty(SqlProcedure)) {
        sb.AppendLine($"  SQL Procedure: {SqlProcedure}");
      }
      if (SqlLineNumber.HasValue) {
        sb.AppendLine($"  SQL Line Number: {SqlLineNumber}");
      }
      if (!string.IsNullOrEmpty(SqlSource)) {
        sb.AppendLine($"  SQL Source: {SqlSource}");
      }
      if (Errorcode.HasValue) {
        sb.AppendLine($"  Error Code: {Errorcode}");
      }
      if (!string.IsNullOrEmpty(WorkstationId)) {
        sb.AppendLine($"  Workstation ID: {WorkstationId}");
      }
      if (!string.IsNullOrEmpty(AllSqlExceptionData)) {
        sb.AppendLine($"    *** All SQL Information ***");
        sb.AppendLine($"      {AllSqlExceptionData}");
      }
    }
    sb.AppendLine($"    *** Stack Trace ***");
    sb.AppendLine($"    {StackTraceListing}");
    sb.AppendLine();

    return sb.ToString();
  }
  #endregion
}
