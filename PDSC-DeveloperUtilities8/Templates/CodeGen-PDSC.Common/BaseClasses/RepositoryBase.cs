namespace PDSC.Common;

/// <summary>
/// All repository classes should inherit from this class
/// </summary>
public class RepositoryBase : CommonBase
{
  #region Private Variables
  private int _RowsAffected;
  #endregion

  #region Public Properties
  public DataResponseBase? ResponseObject { get; set; }

  /// <summary>
  /// Get/Set RowsAffected
  /// </summary>
  public int RowsAffected
  {
    get { return _RowsAffected; }
    set
    {
      _RowsAffected = value;
      RaisePropertyChanged(nameof(RowsAffected));
    }
  }
  #endregion
}
