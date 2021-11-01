namespace PDSC.Common.TextProcessing
{
  /// <summary>
  /// Class for keyword/text replacement for text processor
  /// </summary>
  public class TextProcessorReplacement : CommonBase
  {   
    #region Public Properties
    /// <summary>
    /// Get/Set the keyword to locate within the email
    /// NOTE: Do not put any tokens around this keyword.
    /// </summary>
    public string Keyword { get; set; }
    /// <summary>
    /// Get/Set the Replacement value to replace in the location of the keyword
    /// </summary>
    public string Replacement { get; set; }
    #endregion

    #region ToString Override
    /// <summary>
    /// Override of ToString. Returns Keyword: Replacement
    /// </summary>
    /// <returns>String of Keyword: Replacement</returns>
    public override string ToString()
    {
      return Keyword + ": " + Replacement;
    }
    #endregion
  }
}
