using System;
using System.Collections.Generic;

namespace PDSC.Common.TextProcessing
{
  /// <summary>
  /// This class is used to take some text that has replaceable tokens and replaces those tokens with values
  /// Tokens are defined with curly braces {AppName}, {CompanyName}, etc.
  /// You can define any tokens you want and then supply the text to do the replacement.
  /// </summary>
  public class TextProcessor : CommonBase
  {
    #region Constructor
    /// <summary>
    /// Constructor for the TextProcessor class
    /// </summary>
    public TextProcessor()
    {
      Init();
    }
    #endregion

    #region Init Method
    /// <summary>
    /// Initialize properties to a valid start state
    /// </summary>
    public override void Init()
    {
      KeywordReplacements = new List<TextProcessorReplacement>
      {
        new TextProcessorReplacement { Keyword = "{Date}", Replacement = DateTime.Now.ToShortDateString() },
        new TextProcessorReplacement { Keyword = "{Time}", Replacement = DateTime.Now.ToShortTimeString() },
        new TextProcessorReplacement { Keyword = "{DateTime}", Replacement = DateTime.Now.ToString() },
        new TextProcessorReplacement { Keyword = "{EnvironmentUserName}", Replacement = Environment.UserName }
      };

      TextResult = string.Empty;
      TokenStart = "{";
      TokenEnd = "}";
    }
    #endregion

    #region Private Variables
    private string _Text;
    private string _TextResult;
    private string _Messages;
    private string _TokenStart;
    private string _TokenEnd;
    private string _Subject;
    private bool _IsValid;
    private List<TextProcessorReplacement> _KeywordReplacements;
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set Text to process
    /// </summary>
    public string Text
    {
      get { return _Text; }
      set {
        _Text = value;
        RaisePropertyChanged("Text");
      }
    }

    /// <summary>
    /// Get/Set the Text result from processing
    /// </summary>
    public string TextResult
    {
      get { return _TextResult; }
      set {
        _TextResult = value;
        RaisePropertyChanged("TextResult");
      }
    }

    /// <summary>
    /// Get/Set any error messages to pass back from this process
    /// </summary>
    public string Messages
    {
      get { return _Messages; }
      set {
        _Messages = value;
        RaisePropertyChanged("Messages");
      }
    }

    /// <summary>
    /// Get/Set the Token that delimits the start of the keyword.
    /// </summary>
    public string TokenStart
    {
      get { return _TokenStart; }
      set {
        _TokenStart = value;
        RaisePropertyChanged("TokenStart");
      }
    }

    /// <summary>
    /// Get/Set the Token that delimits the end of the keyword.
    /// </summary>
    public string TokenEnd
    {
      get { return _TokenEnd; }
      set {
        _TokenEnd = value;
        RaisePropertyChanged("TokenEnd");
      }
    }

    /// <summary>
    /// Get/Set the Subject of the text. This is filled in if a &gt;title&lt; tag is found in text.
    /// </summary>
    public string Subject
    {
      get { return _Subject; }
      set {
        _Subject = value;
        RaisePropertyChanged("Subject");
      }
    }

    /// <summary>
    /// Get/Set whether or not the text replacement was successful
    /// </summary>
    public bool IsValid
    {
      get { return _IsValid; }
      set {
        _IsValid = value;
        RaisePropertyChanged("IsValid");
      }
    }

    /// <summary>
    /// Get/Set the list of keywords to locate within the text and the values to replace them with
    /// </summary>
    public List<TextProcessorReplacement> KeywordReplacements
    {
      get { return _KeywordReplacements; }
      set {
        _KeywordReplacements = value;
        RaisePropertyChanged("KeywordReplacements");
      }
    }
    #endregion

    #region Process Methods
    /// <summary>
    /// Call this method if you have a text string with delimiters ready to be processed.
    /// This method is called after you read the text string from a file or a database table.
    /// </summary>
    /// <returns>The finished text</returns>
    public virtual string Process()
    {
      return Process(Text);
    }

    /// <summary>
    /// Call this method if you have a text string with delimiters ready to be processed.
    /// This method is called after you read the text string from a file or a database table.
    /// </summary>
    /// <param name="textToProcess">The text to process</param>
    /// <returns>The finished text</returns>
    public virtual string Process(string textToProcess)
    {
      IsValid = false;

      // Update standard date/time keywords
      UpdateDateTimeKeywords();

      if (!string.IsNullOrEmpty(textToProcess)) {
        TextResult = textToProcess;
        // Process all key/value pairs
        foreach (TextProcessorReplacement item in KeywordReplacements) {
          if (!item.Keyword.Contains(TokenStart)) {
            item.Keyword = TokenStart + item.Keyword + TokenEnd;
          }
          TextResult = TextResult.Replace(item.Keyword, item.Replacement);
        }

        // Remove any instructions
        if (TextResult.Contains("<!-- BEGIN INSTRUCTIONS -->") &&
            TextResult.Contains("<!-- END INSTRUCTIONS -->")) {
          int posStart;
          int posEnd;

          posStart = TextResult.IndexOf("<!-- BEGIN INSTRUCTIONS -->");
          posEnd = TextResult.IndexOf("<!-- END INSTRUCTIONS -->") + "<!-- END INSTRUCTIONS -->".Length;

          if (posStart >= 0) {
            TextResult = TextResult.Remove(posStart, posEnd - posStart);
          }
        }

        IsValid = true;
      }
      else {
        Messages = "Text is blank.";
      }

      // Process Subject (if applicable)
      if (string.IsNullOrEmpty(Subject)) {
        if (TextResult.ToLower().IndexOf("<title>") >= 0 &&
            TextResult.ToLower().IndexOf("</title>") >= 0) {
          Subject = TextResult.Substring(TextResult.ToLower().IndexOf("<title>") + 7);
          Subject = Subject.Substring(0, Subject.IndexOf("</title>")).Trim();
        }

        // Do any replacements in Subject
        if (!string.IsNullOrEmpty(Subject)) {
          foreach (TextProcessorReplacement item in KeywordReplacements) {
            if (!item.Keyword.Contains(TokenStart)) {
              item.Keyword = TokenStart + item.Keyword + TokenEnd;
            }
            Subject = Subject.Replace(item.Keyword, item.Replacement);
          }
        }
      }

      return TextResult;
    }
    #endregion

    #region UpdateDateTimeKeywords Method
    /// <summary>
    /// This method updates the following tokens with the current date/time.
    /// {Date}=DateTime.Now.ToShortDateString()
    /// {Time}=DateTime.Now.ToShortDateString()
    /// {DateTime}=DateTime.Now.ToString()
    /// </summary>
    public virtual void UpdateDateTimeKeywords()
    {
      TextProcessorReplacement tpr = KeywordReplacements.Find(k => k.Keyword == "{Date}");
      if (tpr != null) {
        tpr.Replacement = DateTime.Now.ToShortDateString();
      }
      tpr = KeywordReplacements.Find(k => k.Keyword == "{Time}");
      if (tpr != null) {
        tpr.Replacement = DateTime.Now.ToShortTimeString();
      }
      tpr = KeywordReplacements.Find(k => k.Keyword == "{DateTime}");
      if (tpr != null) {
        tpr.Replacement = DateTime.Now.ToString();
      }
    }
    #endregion

    #region RemoveWhitespace Method
    protected virtual string RemoveWhitespace(string text)
    {
      return text.Replace(Environment.NewLine, "").Replace("\n\r", "").Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
    }
    #endregion

    #region AddKeywordReplacement Method
    /// <summary>
    /// Use this method to add keyword replacements
    /// </summary>
    /// <param name="key">The token in the text</param>
    /// <param name="value">The value to replace into the token</param>
    public void AddKeywordReplacement(string key, string value)
    {
      if (key.Contains(TokenStart)) {
        KeywordReplacements.Add(new TextProcessorReplacement { Keyword = key.Trim(), Replacement = value });
      }
      else {
        KeywordReplacements.Add(new TextProcessorReplacement { Keyword = TokenStart + key.Trim() + TokenEnd, Replacement = value });
      }
    }
    #endregion
    
    #region ChangeReplacementForKeyword Method
    /// <summary>
    /// Use this method to change a replacement for an exiting keyword
    /// </summary>
    /// <param name="key">The token in the text</param>
    /// <param name="value">The value to replace into the token</param>
    public void ChangeReplacementForKeyword(string key, string value)
    {
      if (!key.Contains(TokenStart)) {
        key = TokenStart + key + TokenEnd;
      }
      var tpr = KeywordReplacements.Find(k => k.Keyword == key);
      if (tpr != null) {
        tpr.Replacement = value;
      }
    }
    #endregion
  }
}
