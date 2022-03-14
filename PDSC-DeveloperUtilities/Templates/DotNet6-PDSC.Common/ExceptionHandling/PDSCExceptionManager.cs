#nullable disable

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace PDSC.Common {
  public class PDSCExceptionManager : CommonBase {
    #region Constructors
    public PDSCExceptionManager(Exception ex) : base() {
      LastException = ex;
      SetExceptionInformation();
    }

    public PDSCExceptionManager(Exception ex, DbContext db) : base() {
      LastException = ex;
      DbContextObject = db;
      SetExceptionInformation();
    }

    public PDSCExceptionManager(Exception ex, DbContext db, IQueryable query) : base() {
      LastException = ex;
      DbContextObject = db;
      QueryObject = query;
      SetExceptionInformation();
    }
    #endregion

    #region Public Properties
    public PDSCException ExceptionObject { get; set; }
    public DbContext DbContextObject { get; set; }
    public IQueryable QueryObject { get; set; }
    #endregion

    #region SetExceptionInformation Method
    public virtual void SetExceptionInformation() {
      SqlException ex = null;

      // Determine type of exception
      if (LastException.GetType().Name == "SqlException") {
        ex = (SqlException)LastException;
      }
      if (LastException.GetType().Name == "EntityCommandExecutionException") {
        ex = (SqlException)LastException.InnerException;
      }

      // Create instance of PDSCException object
      ExceptionObject = new PDSCException(ex.Message);

      // Get SQL Server Information
      if (ex != null) {
        LastErrorMessage = ex.Message ?? LastException.Message;
        ExceptionObject.StackTraceListing = ex.StackTrace;
        ExceptionObject.IsDataException = true;
        ExceptionObject.Errorcode = ex.ErrorCode;
        ExceptionObject.SqlNumber = ex.Number;
        ExceptionObject.SqlClass = ex.Class;
        ExceptionObject.SqlLineNumber = ex.LineNumber;
        ExceptionObject.SqlProcedure = ex.Procedure;
        ExceptionObject.SqlServer = ex.Server;
        ExceptionObject.SqlSource = ex.Source;

        SetAllSqlExceptionData(ex);
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

      if (QueryObject != null) {
        ExceptionObject.SqlQuery = QueryObject.ToString();
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
}