using Microsoft.Extensions.Logging;
using PDSC.Common.HelperClasses;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace PDSC.Common;

/// <summary>
/// All view model classes should inherit from this class
/// <typeparam name="TEntity">An entity type</typeparam>
/// <typeparam name="TSearch">An entity search type</typeparam>
/// </summary>
public abstract class ViewModelBase<TEntity, TSearch> : CommonBase
{
  #region Private Variables
  private int _RowsAffected;
  private bool _IsDataProcessing = true;
  private bool _IsDetailVisible;
  private bool _HasValidationErrors;
  private bool _IsAdding;
  private ObservableCollection<ValidationMessage> _ValidationMessages = new();
  #endregion

  #region Public Properties
  /// <summary>
  /// Get/Set the total number of rows returned from the last query
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

  /// <summary>
  /// Get/Set if data is being processed
  /// </summary>
  public bool IsDataProcessing
  {
    get { return _IsDataProcessing; }
    set
    {
      _IsDataProcessing = value;
      RaisePropertyChanged(nameof(IsDataProcessing));
    }
  }

  /// <summary>
  /// Get/Set if the detail area is visible
  /// </summary>
  public bool IsDetailVisible
  {
    get { return _IsDetailVisible; }
    set
    {
      _IsDetailVisible = value;
      RaisePropertyChanged(nameof(IsDetailVisible));
    }
  }

  /// <summary>
  /// Get/Set if the current selected entity has passed all validation
  /// </summary>
  public bool HasValidationErrors
  {
    get { return _HasValidationErrors; }
    set
    {
      _HasValidationErrors = value;
      RaisePropertyChanged(nameof(HasValidationErrors));
    }
  }

  /// <summary>
  /// Get/Set whether or not the page is in add mode
  /// </summary>
  public bool IsAdding
  {
    get { return _IsAdding; }
    set
    {
      _IsAdding = value;
      RaisePropertyChanged(nameof(IsAdding));
    }
  }

  /// <summary>
  /// Get/Set a list of validation messages to display
  /// </summary>
  public ObservableCollection<ValidationMessage> ValidationMessages
  {
    get { return _ValidationMessages; }
    set
    {
      _ValidationMessages = value;
      RaisePropertyChanged(nameof(ValidationMessages));
    }
  }

  /// <summary>
  /// Get/Set a instance of a ILogger object
  /// </summary>
  public ILogger? LoggerObject { get; set; }
  #endregion

  #region Abstract Methods
  public abstract TEntity SetValues(TEntity current, TEntity changes);
  public abstract TEntity CreateEmpty();
  #endregion

  #region Validate Method
  public bool Validate<T>(T entity)
  {
    ValidationMessages.Clear();
    
    if (entity != null) {
      // Create instance of ValidationContext object
      ValidationContext context = new(entity, serviceProvider: null, items: null);
      List<ValidationResult> results = new();

      // Call TryValidateObject() method
      if (!Validator.TryValidateObject(entity, context, results, true)) {
        // Get validation results
        foreach (ValidationResult item in results) {         
          string propName = string.Empty;
          if (item.MemberNames.Any()) {
            propName = ((string[])item.MemberNames)[0];
          }
          // Build new ValidationMessage object
          ValidationMessage msg = new() {
            Message = item.ErrorMessage ?? string.Empty,
            PropertyName = propName
          };

          // Add validation object to list
          ValidationMessages.Add(msg);
        }
      }
    }

    HasValidationErrors = ValidationMessages.Count > 0;

    return !HasValidationErrors;
  }
  #endregion

  #region ResetRowsAffectedAndMessages Method
  protected virtual void ResetRowsAffectedAndMessages()
  {
    base.ResetMessages();
    RowsAffected = 0;
    IsDataProcessing = true;
  }
  #endregion

  #region SetRepositoryNotSetStatus Method
  protected virtual void SetRepositoryNotSetStatus<T>(DataResponse<T> response) {
    response.StatusMessage = "InternalServerError";
    response.ResultMessage = RepositoryNotSetMessage;
    response.StatusCode = HttpStatusCode.InternalServerError;
  }
  #endregion

  #region SetGenericExceptionStatus Method
  protected virtual DataResponse<T> SetGenericExceptionStatus<T>(DataResponse<T> response, string msg)
  {
    // Do NOT send the real exception to the user
    response.StatusMessage = "InternalServerError";
    response.LastErrorMessage = msg;
    response.ResultMessage = msg;
    response.LastException = null;
    response.StatusCode = HttpStatusCode.InternalServerError;

    return response;
  }
  #endregion

  #region SetValidationStatus Method
  protected virtual void SetValidationStatus<T>(DataResponse<T> ret, T? entity, ObservableCollection<ValidationMessage> messages)
  {
    // Validation Errors
    RowsAffected = 0;

    // Validation Errors, return a '422 Unprocessable Entity'
    ret.Data = entity;
    ret.StatusMessage = "ValidationError";
    ret.ResultMessage = JsonHelper.SerializeEntity<ObservableCollection<ValidationMessage>>(messages);
    ret.StatusCode = HttpStatusCode.UnprocessableEntity;
  }
  #endregion

  #region SetInfoAndErrorMessages Methods
  protected virtual void SetInfoAndErrorMessages<T>(DataResponse<T> response)
  {
    InfoMessage = response.ResultMessage ?? string.Empty;
    LastException = response.LastException;
    LastErrorMessage = response.LastErrorMessage ?? string.Empty;
    IsDataProcessing = false;
  }
  #endregion

  #region PublishException Methods
  protected virtual void PublishException(Exception ex)
  {
    LastException = ex;

    LogException(ex);
  }

  protected virtual void PublishException<T>(Exception ex, DataResponse<T> dr)
  {
    LastException = ex;

    // TODO: Gather information from the DataResponse object

    // Log Exception
    LogException(ex);
  }
  #endregion

  #region LogException Methods
  /// <summary>
  /// Log your exceptions using this method
  /// This should be overridden in your AppViewModel class
  /// </summary>
  /// <param name="ex">An instance of a Exception object</param>
  protected virtual void LogException(Exception ex)
  {
    LoggerObject?.LogError("{Message}", ex.ToString());
  }
  /// <summary>
  /// Log your exceptions using this method
  /// This should be overridden in your AppViewModel class
  /// </summary>
  /// <param name="ex">An instance of a PDSCException object</param>
  protected virtual void LogException(PDSCException ex)
  {
    LoggerObject?.LogError("{Message}", ex.ToString());
  }
  #endregion
}
