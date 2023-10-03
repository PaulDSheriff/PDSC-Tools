using System.ComponentModel;

namespace PDSC.Common;

public class ValidationMessage : INotifyPropertyChanged
{
  private string _PropertyName = string.Empty;
  private string _Message = string.Empty;

  /// <summary>
  /// Get/Set PropertyName
  /// </summary>
  public string PropertyName
  {
    get { return _PropertyName; }
    set
    {
      _PropertyName = value;
      RaisePropertyChanged(nameof(PropertyName));
    }
  }

  /// <summary>
  /// Get/Set Message
  /// </summary>
  public string Message
  {
    get { return _Message; }
    set
    {
      _Message = value;
      RaisePropertyChanged(nameof(Message));
    }
  }

  #region RaisePropertyChanged Method
  /// <summary>
  /// Event used to raise changes to any bound UI objects
  /// </summary>
  public event PropertyChangedEventHandler? PropertyChanged;

  public virtual void RaisePropertyChanged(string propertyName)
  {
    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
  #endregion

  #region ToString Override
  public override string ToString()
  {
    return $"{Message}  ({PropertyName})";
  }
  #endregion
}
