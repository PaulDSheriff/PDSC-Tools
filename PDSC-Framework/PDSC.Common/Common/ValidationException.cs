using System;
using System.Collections.Generic;

namespace PDSC.Common
{
  /// <summary>
  /// Use this class to throw a validation exception from a view model
  /// </summary>
  public class ValidationException : Exception
  {
    public ValidationException() : base()
    {
      ValidationMessages = new List<ValidationMessage>();
    }

    public ValidationException(List<ValidationMessage> messages) : base()
    {
      if (messages == null) {
        ValidationMessages = new List<ValidationMessage>();
      }

      ValidationMessages = messages;
    }

    public List<ValidationMessage> ValidationMessages { get; set; }
  }
}
