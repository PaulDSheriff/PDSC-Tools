using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace PDSC.Common;

public class PDSCExceptionManager : CommonBase {
  #region Constructors
  public PDSCExceptionManager(Exception ex) : base() {
    LastException = ex;
    DbContextObject = null;
    SetExceptionInformation();
  }

  public PDSCExceptionManager(Exception ex, DbContext? db) : base() {
    LastException = ex;
    DbContextObject = db;
    SetExceptionInformation();
  }
  #endregion

  #region Public Properties
  public PDSCException ExceptionObject { get; set; } = new();
  public DbContext? DbContextObject { get; set; }
  #endregion

  #region SetExceptionInformation Method
  public virtual void SetExceptionInformation() {
    SqlException? sqlex = null;

    // Create instance of PDSCException object
    ExceptionObject = new PDSCException("No SQL Exception");

    // Determine type of exception
    if (LastException?.GetType().Name == "SqlException") {
      sqlex = (SqlException)LastException;
      ExceptionObject = new PDSCException(sqlex.Message);
    }
    if (LastException?.GetType().Name == "EntityCommandExecutionException") {
      if (LastException.InnerException != null) {
        sqlex = (SqlException)LastException.InnerException;
        ExceptionObject = new PDSCException(sqlex.Message);
      }
    }

    // Get SQL Server Information
    if (sqlex != null) {
      LastErrorMessage = sqlex.Message ?? (LastException?.Message ?? "");
      ExceptionObject.StackTraceListing = sqlex.StackTrace ?? string.Empty;
      ExceptionObject.IsDataException = true;
      ExceptionObject.Errorcode = sqlex.ErrorCode;
      ExceptionObject.SqlNumber = sqlex.Number;
      ExceptionObject.SqlClass = sqlex.Class;
      ExceptionObject.SqlLineNumber = sqlex.LineNumber;
      ExceptionObject.SqlProcedure = sqlex.Procedure;
      ExceptionObject.SqlServer = sqlex.Server;
      ExceptionObject.SqlSource = sqlex.Source;

      SetAllSqlExceptionData(sqlex);
    }

    // Set Database Information
    SetDatabaseInformation();
  }
  #endregion

  #region SetAllSqlExceptionData Method
  public virtual string SetAllSqlExceptionData(SqlException ex) {
    StringBuilder sb = new(1024);

    for (int index = 0; index <= ex.Errors.Count - 1; index++) {
      sb.AppendLine("Index #" + index);
      sb.AppendLine("Source: " + ex.Errors[index].Source);
      sb.AppendLine("Number: " + ex.Errors[index].Number.ToString());
      sb.AppendLine("State: " + ex.Errors[index].State.ToString());
      sb.AppendLine("Class: " + ex.Errors[index].Class.ToString());
      sb.AppendLine("Server: " + ex.Errors[index].Server);
      sb.AppendLine("Message: " + ex.Errors[index].Message);
      sb.AppendLine("Procedure: " + ex.Errors[index].Procedure);
      sb.AppendLine("LineNumber: " + ex.Errors[index].LineNumber.ToString());
      sb.AppendLine();
    }

    ExceptionObject.AllSqlExceptionData = sb.ToString();

    return ExceptionObject.AllSqlExceptionData;
  }
  #endregion

  #region SetDatabaseInformation Method
  public virtual void SetDatabaseInformation() {
    if (DbContextObject != null) {
      ExceptionObject.ConnectionString = HideLoginInfoForConnectionString(DbContextObject.Database.GetDbConnection().ConnectionString);
      ExceptionObject.DatabaseName = DbContextObject.Database.GetDbConnection().Database;
      ExceptionObject.SqlServer = ExceptionObject.SqlServer ?? DbContextObject.Database.GetDbConnection().DataSource;
      ExceptionObject.WorkstationId = ((SqlConnection)DbContextObject.Database.GetDbConnection()).WorkstationId;
    }
  }
  #endregion

  #region HideLoginInfoForConnectionString Method
  /// <summary>
  /// Looks for UID, User Id, Pwd, Password, etc. in a connection string and replaces their 'values' with astericks.
  /// </summary>
  /// <param name="connectString">The connection string to check</param>
  /// <returns>A string with hidden user id and password values</returns>
  public virtual string HideLoginInfoForConnectionString(string connectString) {
    if (!string.IsNullOrEmpty(connectString)) {
      SqlConnectionStringBuilder cnb = new(connectString);

      if (!string.IsNullOrEmpty(cnb.UserID)) {
        cnb.UserID = "*******";
        cnb.Password = "*******";
      }

      return cnb.ToString();
    }
    else {
      return string.Empty;
    }
  }
  #endregion
}
