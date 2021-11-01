using System;
using System.IO;

namespace PDSC.Common.TextProcessing
{
  /// <summary>
  /// This class is used to create an email using replaceable tokens
  /// Tokens are defined with curly braces {AppName}, {CompanyName}, etc.
  /// You can define any tokens you want and then supply the text to do the replacement.
  /// </summary>
  public class TextProcessorFile : TextProcessor
  {
    #region Constructors    
    public TextProcessorFile() : base()
    {
    }

    /// <summary>
    /// Constructor for the EmailProcessor class
    /// </summary>
    /// <param name="textFile">The text file to read in</param>
    public TextProcessorFile(string textFile) : base()
    {
      TextFile = textFile;
    }
    #endregion

    #region Public Properties   
    /// <summary>
    /// Get/Set the full path and file name of the text file to process
    /// </summary>
    public string TextFile { get; set; }
    #endregion

    #region ReadTextFileAndProcess Methods
    /// <summary>
    /// Call this method after setting the TextFile property to the location of a valid file name
    /// </summary>
    /// <returns>The processed text from the text file</returns>
    public virtual string ReadTextFileAndProcess()
    {
      return ReadTextFileAndProcess(TextFile);
    }

    /// <summary>
    /// This method reads the text file and processes the text
    /// </summary>
    /// <param name="textFile">The text file to read from</param>
    /// <returns>The processed text from the text file</returns>
    public virtual string ReadTextFileAndProcess(string textFile)
    {
      TextFile = textFile;

      if (!string.IsNullOrEmpty(TextFile)) {
        if (File.Exists(TextFile)) {
          try {
            TextResult = Process(File.ReadAllText(TextFile));
          }
          catch (Exception ex) {
            Messages = ex.ToString();
          }
        }
        else {
          Messages = "Text file can't be found: " + TextFile;
        }
      }
      
      return TextResult;
    }
    #endregion
  }
}
