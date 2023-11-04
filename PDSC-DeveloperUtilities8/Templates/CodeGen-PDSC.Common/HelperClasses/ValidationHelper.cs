using System.ComponentModel.DataAnnotations;

namespace PDSC.Common;

public static class ValidationHelper
{
  public static Dictionary<string, string[]> Validate<T>(T? entity)
  {
    Dictionary<string, string[]> ret = new();

    if (entity != null) {
      // Create instance of ValidationContext object
      ValidationContext context = new(entity, serviceProvider: null, items: null);
      List<ValidationResult> results = new();

      // Call TryValidateObject() method
      if (!Validator.TryValidateObject(entity, context, results, true)) {
        // Get validation results
        foreach (ValidationResult item in results) {
          string propName = string.Empty;
          if (item.MemberNames.Any()) {
            propName = ((string[])item.MemberNames)[0];
          }
          // Create new dictionary object
          ret.Add(propName, new string[] {
            item.ErrorMessage ?? "Unknown Validation Error"
          });
        }
      }
    }

    return ret;
  }
}
