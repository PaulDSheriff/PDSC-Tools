using System;
using System.Globalization;
using System.Windows.Data;

namespace PDSC.Common.WPF.Converters;

public class InvertedBoolConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
    return !(bool)value;
  }

  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
    return new object();
  }
}
