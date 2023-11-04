using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace PDSC.Common.Web;

public abstract class RouterBase
{
  public RouterBase(ILogger logger)
  {
    UrlFragment = string.Empty;
    TagName = string.Empty;
    InfoMessage = string.Empty;
    ErrorLogMessage = string.Empty;
    EntityAsJson = string.Empty;
    _Logger = logger;
  }

  public string UrlFragment;
  public string TagName;
  public string EntityAsJson { get; set; }
  public string InfoMessage { get; set; }
  public string ErrorLogMessage { get; set; }
  protected readonly ILogger _Logger;

  public abstract void AddRoutes(WebApplication app);

  /// <summary>
  /// Serialize an object into a JSON string
  /// </summary>
  /// <typeparam name="T">The type to serialize</typeparam>
  /// <param name="entity">An instance of the type</param>
  /// <returns>A JSON string</returns>
  protected string SerializeEntity<T>(T? entity)
  {
    EntityAsJson = "Nothing serialized";

    try {
      // Attempt to serialize entity
      EntityAsJson = JsonSerializer.Serialize(entity);
    }
    catch {
      // Ignore the error
    }

    return EntityAsJson;
  }

  /// <summary>
  /// Call this method to return a '500 Internal Server Error' and log an exception.
  /// </summary>
  /// <param name="ex">An Exception object</param>
  /// <param name="infoMsg">The info message to display to the user<param>
  /// <param name="errorMsg">The error message to log</param>
  /// <returns>A Status Code of 500</returns>
  protected IResult HandleException(Exception ex, string infoMsg, string errorMsg)
  {
    // Set properties from parameters passed in
    InfoMessage = infoMsg;
    ErrorLogMessage = errorMsg;

    return HandleException(ex);
  }

  /// <summary>
  /// Call this method to return a '500 Internal Server Error' and log an exception.
  /// Prior to calling this method...
  ///    Fill in the InfoMessage property with the value to display to the caller.
  ///    Fill in the ErrorLogMessage property with the value to place into the log file.
  /// </summary>
  /// <param name="ex">An Exception object</param>
  /// <returns>A Status Code of 500</returns>
  protected IResult HandleException(Exception ex)
  {
    IResult ret;

    // Create status code with generic message
    ret = Results.Problem(InfoMessage);

    // Add Message, Source, and Stack Trace
    ErrorLogMessage += $"{Environment.NewLine}Message: {ex.Message}";
    ErrorLogMessage += $"{Environment.NewLine}Source: {ex.Source}";
    ErrorLogMessage += $"{Environment.NewLine}Stack Trace: {ex.StackTrace}";

    // Log the exception
    _Logger.LogError(ex, "{ErrorLogMessage}", ErrorLogMessage);

    return ret;
  }
}
