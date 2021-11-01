using System;
using System.Globalization;

namespace PDSC.Common
{
  /// <summary>
  /// A class for helping you work with Dates.
  /// </summary>
  public class DateHelper
  {
    /// <summary>
    /// Returns the current date and time in a string in a yyyy-MM-dd HH:mm:ss format. This is commonly used to insert into a SQL Server database.
    /// </summary>
    /// <returns>String</returns>
    public static string NowFormatted()
    {
      return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    /// <summary>
    /// Returns the date and time passed into this method in a string in a yyyy-MM-dd HH:mm:ss format. This is commonly used to insert into a SQL Server database.
    /// </summary>
    /// <param name="dt">A Date/Time Value</param>
    /// <returns>String</returns>
    public static string NowFormatted(DateTime dt)
    {
      return dt.ToString("yyyy-MM-dd HH:mm:ss");
    }

    /// <summary>
    /// Returns the current date/time passed in using the format string passed in.
    /// </summary>
    /// <param name="dateFormat">A format string</param>
    /// <returns>String</returns>
    public static string NowFormatted(string dateFormat)
    {
      return DateTime.Now.ToString(dateFormat);
    }

    /// <summary>
    /// Returns the first day of the month for the date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DateTime</returns>
    public static DateTime MonthStart(DateTime value)
    {
      return new DateTime(value.Year, value.Month, 1, 0, 0, 0, 0, CultureInfo.CurrentCulture.Calendar);
    }

    /// <summary>
    /// Returns the last day of the month for the date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DateTime</returns>
    public static DateTime MonthEnd(DateTime value)
    {
      int lastDay;
      DateTime dt;

      lastDay = DateTime.DaysInMonth(value.Year, value.Month);

      dt = new DateTime(value.Year, value.Month, lastDay, 12, 59, 59, 0, CultureInfo.CurrentCulture.Calendar);

      return dt;
    }

    /// <summary>
    /// Returns a Date that is the first day of the quarter for the given date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DateTime</returns>
    public static DateTime QuarterStart(DateTime value)
    {
      DateTime dt = DateTime.MinValue;

      switch (value.Month) {
        case 1:
        case 2:
        case 3:
          dt = new DateTime(value.Year, 1, 1, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 4:
        case 5:
        case 6:
          dt = new DateTime(value.Year, 4, 1, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 7:
        case 8:
        case 9:
          dt = new DateTime(value.Year, 7, 1, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 10:
        case 11:
        case 12:
          dt = new DateTime(value.Year, 10, 1, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;

        default:
          break;
      }

      return dt;
    }

    /// <summary>
    /// Returns a Date that is the last day of the quarter for the given date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DataTime</returns>
    public static DateTime QuarterEnd(DateTime value)
    {
      DateTime dt = DateTime.MinValue;

      switch (value.Month) {
        case 1:
        case 2:
        case 3:
          dt = new DateTime(value.Year, 3, 31, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 4:
        case 5:
        case 6:
          dt = new DateTime(value.Year, 6, 30, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 7:
        case 8:
        case 9:
          dt = new DateTime(value.Year, 9, 30, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;
        case 10:
        case 11:
        case 12:
          dt = new DateTime(value.Year, 12, 31, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);
          break;

        default:
          break;
      }

      return dt;
    }

    /// <summary>
    /// Returns the first day of the year for the given date passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DateTime</returns>
    public static DateTime YearStart(DateTime value)
    {
      DateTime dt;

      dt = new DateTime(value.Year, 1, 1, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);

      return dt;
    }

    /// <summary>
    /// Returns the last day of the year for the given date value passed in.
    /// </summary>
    /// <param name="value">DateTime</param>
    /// <returns>DateTime</returns>
    public static DateTime YearEnd(DateTime value)
    {
      DateTime dt;

      dt = new DateTime(value.Year, 12, 31, value.Hour, value.Minute, value.Second, value.Millisecond, CultureInfo.CurrentCulture.Calendar);

      return dt;
    }

    /// <summary>
    /// Returns the number of the quarter that the given date falls within.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>DateTime</returns>
    public static int GetQuarter(DateTime value)
    {
      // Get the current month
      int ret = 1;

      switch (value.Month) {
        case 1:
        case 2:
        case 3:
          ret = 1;
          break;

        case 4:
        case 5:
        case 6:
          ret = 2;
          break;

        case 7:
        case 8:
        case 9:
          ret = 3;
          break;

        case 10:
        case 11:
        case 12:
          ret = 4;
          break;

        default:
          break;
      }

      return ret;
    }

    /// <summary>
    /// Gets the number of seconds that have elapsed since midnight of the current date/time.
    /// </summary>
    /// <returns>Double</returns>
    public static double GetSecondsSinceMidnight()
    {
      // Create the timespan object get the time between the dates
      TimeSpan st = DateTime.Now.Subtract(System.DateTime.Today);

      // Return the number of seconds
      return st.Duration().TotalMilliseconds / 1000;
    }

    /// <summary>
    /// Returns the week number for the given date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>int</returns>
    public static int GetWeek(DateTime value)
    {
      DateTimeFormatInfo d = new();

      // Receives the DateTime, Rule to start first day and first starting day (Mon, tue etc)
      return d.Calendar.GetWeekOfYear(value, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
    }

    /// <summary>
    /// Returns the Month Name for the given date value passed in.
    /// </summary>
    /// <param name="value">A Date Value</param>
    /// <returns>String</returns>
    public static string GetMonthName(DateTime value)
    {
      DateTimeFormatInfo dtfi = new();
      string[] arr;

      arr = dtfi.MonthNames;

      return arr[value.Month - 1];
    }

    /// <summary>
    /// Returns the Month Name for a value from 1-12 that is passed in.
    /// </summary>
    /// <param name="value">An integer value between 1 and 12</param>
    /// <returns>string</returns>
    public static string GetMonthName(int value)
    {
      if (value >= 1 && value <= 12) {
        DateTimeFormatInfo dtfi = new();
        string[] arr;

        arr = dtfi.MonthNames;

        return arr[value - 1];
      }
      else
        return "Invalid Number passed to GetMonthName() method";
    }

    /// <summary>
    /// Returns True if the string value passed in is a valid date.
    /// </summary>
    /// <param name="value">A string to be test</param>
    /// <returns>boolean</returns>
    public static bool IsADate(string value)
    {
      bool ret;

      ret = DateTime.TryParse(value, out _);

      return ret;
    }

    /// <summary>
    /// Returns True if the string value passed in is a valid date. This method also allows you to pass in a format such as "yyyyMMdd".
    /// This method does use the CurrentCulture and assumes that your date passed in is in a local format.
    /// </summary>
    /// <param name="value">The date to test</param>
    /// <param name="dateFormat">A valid date format string such as "yyyyMMdd" that the 'value' parameter is in</param>
    /// <returns>True or False</returns>
    public static bool IsADate(string value, string dateFormat)
    {
      bool ret;

      ret = DateTime.TryParseExact(value, dateFormat,
        CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal, out _);

      return ret;
    }

    /// <summary>     
    /// Returns the age of a person in years based on today's date and the birthdate passed in
    /// </summary>     
    /// <param name="birthDate">The date of birth</param>     
    /// <returns>The age in years. If the birth date passed in is a future date, then zero is returned</returns>     
    public static int Age(DateTime birthDate)
    {
      return Age(birthDate, DateTime.Today);
    }

    /// <summary>     
    /// Calculates the age in years of the current System.DateTime object as of later date.     
    /// </summary>     
    /// <param name="birthDate">The date of birth</param>     
    /// <param name="baseDate">The date on which to calculate the age.</param>     
    /// <returns>The age in years</returns>     
    public static int Age(DateTime birthDate, DateTime baseDate)
    {
      int ret;

      ret = baseDate.Year - birthDate.Year;
      if (ret > 0)
        ret -= Convert.ToInt32(baseDate.Date < birthDate.Date.AddYears(ret));
      else
        ret = 0;

      return ret;
    }

    public static DateTime RoundDownHalfHour(DateTime dt)
    {
      if (dt.Minute < 31) {
        return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);
      }
      else {
        return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 30, 0);
      }
    }
  }
}