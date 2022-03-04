#nullable disable

namespace PDSC.Common
{
  /// <summary>
  /// Any class that needs a LastException and LastErrorMessage properties should use this
  /// </summary>
  public abstract class CommonBase
  {
    #region Constructor
    /// <summary>
    /// Constructor for CommonBase
    /// </summary>
    public CommonBase()
    {
      Init();
    }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize this class
    /// </summary>
    public virtual void Init()
    {
      LastErrorMessage = string.Empty;
      LastException = null;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the last error message from the last operation
    /// </summary>
    public string LastErrorMessage { get; set; }
    private Exception _LastException;

    /// <summary>
    /// Get/Set the last exception object from the last operation
    /// Sets the ErrorMessage to LastException.Message if ErrorMessage is blank
    /// </summary>
    public Exception LastException

    {
      get { return _LastException; }
      set
      {
        _LastException = value;
        if (_LastException != null) {
          if (string.IsNullOrEmpty(LastErrorMessage)) {
            LastErrorMessage = _LastException.Message;
          }
        }
      }
    }
    #endregion

    #region RaisePropertyChanged Method
    public virtual void RaisePropertyChanged(string propertyName)
    {
      // NOTE: This method is for WPF applications
    }
    #endregion
  }
}
