namespace PDSC.Common;

/// <summary>
/// Extension methods for the HttpResponseMessage class
/// </summary>
public static class HttpResponseMessageExtensions
{
  public static void WriteRequestToConsole(this HttpResponseMessage response)
  {
    if (response is null) {
      return;
    }

    var request = response.RequestMessage;
    Console.Write($"{request?.Method} ");
    Console.Write($"{request?.RequestUri} ");
    Console.WriteLine($"HTTP/{request?.Version}");
  }
}
