using System;

namespace PDSC.Common.Shopping
{
	/// <summary>
	/// This class holds the properties for credit card processing in an application
	/// </summary>
  public class CreditCardSettings : CommonBase
	{   
    #region Public Properties
    public string ProcessorName { get; set; }
    public string ClientID { get; set; }
    #endregion
  }
}
