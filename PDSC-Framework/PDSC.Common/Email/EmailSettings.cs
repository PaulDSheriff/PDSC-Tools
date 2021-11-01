namespace PDSC.Common
{
	/// <summary>
	/// This class holds the properties for emailing from an application
	/// </summary>
  public class EmailSettings : CommonBase
	{
    #region Public Properties
    public string SMTPServer { get; set; }
    public int SMTPPort { get; set; }
    public string SMTPUserName { get; set; }
    public string SMTPKey { get; set; }

    /// <summary>
    /// Get/Set From Name
    /// </summary>
    public string FromName { get; set; }

    /// <summary>
    /// Get/Set From Email
    /// </summary>
    public string FromEmail { get; set; }

    /// <summary>
    /// Get/Set To Email
    /// </summary>
    public string ToEmail { get; set; }

    /// <summary>
    /// Get/Set Subject
    /// </summary>
    public string Subject { get; set; }

    public string UnsubscribeEmail { get; set; }

    public string UnsubscribeLink { get; set; }
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();

      SMTPServer = string.Empty;
      SMTPPort = 587;
      SMTPKey = string.Empty;
      SMTPUserName = string.Empty;
      FromEmail = string.Empty;
      ToEmail = string.Empty;
      Subject = string.Empty;
    }
    #endregion
  }
}
