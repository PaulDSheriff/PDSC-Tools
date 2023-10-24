namespace PDSC.Common;

public static class GenericsHelpers
{
  public static T ChangeType<T>(object? o)
  {
    Type conversionType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
    if (o == null) {
#pragma warning disable CS8603 // Possible null reference return.
      return default;
#pragma warning restore CS8603 // Possible null reference return.
    }
    else {
      return (T)Convert.ChangeType(o, conversionType);
    }
  }
}
