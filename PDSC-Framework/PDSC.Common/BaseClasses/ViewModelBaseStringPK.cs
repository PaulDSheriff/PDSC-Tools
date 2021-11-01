namespace PDSC.Common
{
  /// <summary>
  /// All view model classes whose repository class does NOT have an 'int' primary key should inherit from this class
  /// </summary>
  public class ViewModelBaseStringPK : ViewModelBase
  {
    #region Properties
    public bool IsSaved { get; set; }
    public bool IsDuplicate { get; set; }
    public string Mode { get; set; }
    #endregion
  }
}