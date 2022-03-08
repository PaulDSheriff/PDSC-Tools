#nullable disable

using Microsoft.EntityFrameworkCore;

namespace PDSC.Common {
  /// <summary>
  /// All view model classes should inherit from this class
  /// </summary>
  public class ViewModelBase : CommonBase {
    #region Constructors
    public ViewModelBase() {

    }

    public ViewModelBase(DbContext db) {
      DbContextObject = db;
    }

    public ViewModelBase(DbContext db, IQueryable query) {
      DbContextObject = db;
      QueryObject = query;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the query object from the repository class
    /// This is mainly used for gathering information for exception logging
    /// </summary>
    public IQueryable QueryObject { get; set; }
    /// <summary>
    /// Get/Set DbContext object for the view model
    /// This is mainly used for gathering information for exception logging
    /// </summary>
    public DbContext DbContextObject { get; set; }

    /// <summary>
    /// Get/Set total number of rows returned from the last query
    /// </summary>
    public int TotalRows { get; set; }

    /// <summary>
    /// Get/Set if the detail area is visible
    /// </summary>
    public bool IsDetailVisible { get; set; }

    /// <summary>
    /// Get/Set if the current selected entity has passed all validation
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// Get/Set whether or not the page is in add mode
    /// </summary>
    public bool IsAdding { get; set; }

    /// <summary>
    /// Get/Set a list of messages to display
    /// </summary>
    public List<string> Messages { get; set; }

    /// <summary>
    /// Get/Set the current message to display
    /// </summary>
    public string Message { get; set; }
    #endregion

    #region Init Method
    public override void Init() {
      base.Init();

      IsDetailVisible = false;
      IsValid = false;
      Messages = new List<string>();
    }
    #endregion

    #region CRUD Methods   
    public virtual void Get(int id) {
    }

    public virtual void Get(string id) {
    }

    public virtual void Get(Guid id) {
    }

    public virtual void Search() {
    }

    public virtual bool Save() {
      return true;
    }

    public virtual bool Delete(int id) {
      return true;
    }

    public virtual bool Delete(string id) {
      return true;
    }

    public virtual bool Delete(Guid id) {
      return true;
    }
    #endregion

    #region Validate Method
    public virtual bool Validate() {
      return true;
    }
    #endregion

    #region CreateEmpty Method
    public virtual void CreateEmpty() {
    }
    #endregion

    #region PublishException Methods
    public virtual void PublishException(Exception ex) {
      PublishException(ex, DbContextObject, QueryObject);
    }

    public virtual void PublishException(Exception ex, DbContext db) {
      PublishException(ex, db, QueryObject);
    }

    public virtual void PublishException(Exception ex, DbContext db, IQueryable query) {
      LastException = ex;
      LastErrorMessage = ex.Message;
      PDSCExceptionManager mgr = new(LastException, db, query);

      // Log Exception
      LogException(mgr.ExceptionObject);

      throw mgr.ExceptionObject;
    }
    #endregion

    #region LogException Methods
    /// <summary>
    /// Log your exceptions using this method
    /// This should be overridden in your AppViewModel class
    /// </summary>
    /// <param name="ex">An instance of a Exception object</param>
    public virtual void LogException(Exception ex) {
      // TODO: Implement Your Logging Here
      System.Diagnostics.Debug.WriteLine(ex.ToString());
    }

    /// <summary>
    /// Log your exceptions using this method
    /// This should be overridden in your AppViewModel class
    /// </summary>
    /// <param name="ex">An instance of a PDSCException object</param>
    public virtual void LogException(PDSCException ex) {
      // TODO: Implement Your Logging Here
      System.Diagnostics.Debug.WriteLine(ex.ToString());
    }
    #endregion
  }
}