using System.Collections.ObjectModel;

namespace PDSC.Common;

public class ValidationError
{
  public string Type { get; set; } = string.Empty;
  public string Title { get; set; } = string.Empty;
  public int Status { get; set; }
  public string TraceId { get; set; } = string.Empty;
  public Dictionary<string, string[]> Errors { get; set; } = new();
  public ObservableCollection<ValidationMessage> ValidationMessages { get; set; } = new();

  public void DictionaryToValidationMessages() {
    // Get validation results   
    foreach (var item in Errors) {
      if (item.Value.Any()) {
        foreach (var vmsg in item.Value) {
          // Add new validation object to list
          ValidationMessages.Add(new() {
            Message = vmsg,
            PropertyName = item.Key
          });
        }
      }      
    }
  }
}