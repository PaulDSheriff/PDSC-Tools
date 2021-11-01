namespace PDSC.Common
{
  /// <summary>
  /// All entity classes with a 'int' primary key and without the PDSC standard fields, should inherit from this base class
  /// </summary>
  public class TableEntityBaseNoStdFields : EntityBase
  {
    #region ShortenString Method
    /// <summary>
    /// Use this method to shorten description fields that might have a large amount of text in them.
    /// This is useful for displaying just a portion of the data in an HTML table.
    /// </summary>
    /// <param name="value">The string value</param>
    /// <param name="maxLength">The max length to cut the string to</param>
    /// <returns></returns>
    public string ShortenString(string value, int maxLength = 50)
    {
      if (!string.IsNullOrEmpty(value)) {
        if (value.Length > maxLength) {
          return value.Substring(0, maxLength);
        }
      }

      return value;
    }
    #endregion
  }
}
