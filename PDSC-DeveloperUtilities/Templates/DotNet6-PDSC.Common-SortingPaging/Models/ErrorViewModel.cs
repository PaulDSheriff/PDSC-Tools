#nullable disable

namespace PDSC.Common.ViewModelLayer
{
  public partial class ErrorViewModel
  {
    public string RequestId { get; set; }
    public string StackTrace { get; set; }
    public string ErrorMessage { get; set; }
    public string ErrorSource { get; set; }
    public string ApplicationName { get; set; }
    public string ContentRootPath { get; set; }

    public string StatusCode { get; set; }
    public string StatusPath { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
  }
}
