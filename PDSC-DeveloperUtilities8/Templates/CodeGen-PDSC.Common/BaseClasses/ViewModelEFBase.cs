using Microsoft.EntityFrameworkCore;

namespace PDSC.Common;

/// <summary>
/// This class should be inherited by any view models that are using the Entity Framework
/// </summary>
/// <typeparam name="TEntity">An entity type</typeparam>
/// <typeparam name="TSearch">An entity search type</typeparam>
public abstract class ViewModelEFBase<TEntity, TSearch> : ViewModelBase<TEntity, TSearch>
{
  #region Constructors
  public ViewModelEFBase() : base()
  {
    DbContextObject = default;
  }

  public ViewModelEFBase(DbContext db)
  {
    DbContextObject = db;
  }
  #endregion

  #region Public Properties
  /// <summary>
  /// Get/Set DbContext object for the view model
  /// This is mainly used for gathering information for exception logging
  /// </summary>
  public DbContext? DbContextObject { get; set; }
  #endregion

  #region PublishException Methods
  public virtual void PublishException(Exception ex, DbContext? db)
  {
    LastException = ex;
    PDSCExceptionManager mgr = new(LastException, db);

    // Log Exception
    LogException(mgr.ExceptionObject);

    throw mgr.ExceptionObject;
  }

  public virtual void PublishException<T>(Exception ex, DataResponse<T> dr, DbContext? db)
  {
    LastException = ex;
    PDSCExceptionManager mgr = new(LastException, db);

    // TODO: Gather information from the DataResponse object

    // Log Exception
    LogException(mgr.ExceptionObject);

    throw mgr.ExceptionObject;
  }
  #endregion
}
