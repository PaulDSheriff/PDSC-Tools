using System.Net;

namespace PDSC.Common;

/// <summary>
/// Use this class when you need to return multiple values from a call
/// </summary>
public class DataResponseBase
{
  public HttpStatusCode StatusCode { get; set; }
  public string? StatusMessage { get; set; } = string.Empty;
  public int RowsAffected { get; set; }
  public string? ResultMessage { get; set; } = string.Empty;
  public Exception? LastException { get; set; }
  public string LastErrorMessage { get; set; } = string.Empty;
}
