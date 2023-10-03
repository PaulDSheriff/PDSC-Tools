namespace PDSC.Common;

/// <summary>
/// Use this class when you need to return multiple values from a call
/// </summary>
/// <typeparam name="T">A data type</typeparam>
public class DataResponse<T> : DataResponseBase
{
  public T? Data { get; set; } = default;
}
