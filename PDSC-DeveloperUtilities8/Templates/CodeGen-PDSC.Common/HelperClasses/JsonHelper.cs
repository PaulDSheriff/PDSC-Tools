using System.Text.Json;

namespace PDSC.Common.HelperClasses;

/// <summary>
/// Helper methods for working with JSON
/// </summary>
public class JsonHelper
{
  #region SerializeEntity Method
  /// <summary>
  /// Serialize an object into a JSON string
  /// </summary>
  /// <typeparam name="T">The type to serialize</typeparam>
  /// <param name="entity">An instance of the type</param>
  /// <returns>A JSON string</returns>
  public static string SerializeEntity<T>(T? entity)
  {
    string ret = "Nothing serialized";

    try {
      // Attempt to serialize entity
      ret = JsonSerializer.Serialize(entity);
    }
    catch {
      // Ignore the error
    }

    return ret;
  }
  #endregion
}
