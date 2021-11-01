namespace PDSC.Common.Shopping
{
  /// <summary>
  /// This class is used to hold month information.
  /// Commonly used in credit card processing
  /// </summary>
  public partial class MonthInfo
  {
    public MonthInfo(short number, string name)
    {
      MonthNumber = number;
      MonthName = name;
    }

    public short MonthNumber { get; set; }
    public string MonthName { get; set; }

    public string MonthNameForDisplay
    {
      get { return MonthNumber.ToString() + " - " + MonthName; }
    }
  }
}
