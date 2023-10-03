namespace PDSC.Common;

public class ValidationException : Exception
{
  public ValidationException() : base()
  {

  }

  public ValidationException(string message) : base(message)
  {

  }

  public ValidationException(ValidationError err) : base()
  {
    ValidationError = err;
  }

  public ValidationError ValidationError { get; set; } = new();
}
