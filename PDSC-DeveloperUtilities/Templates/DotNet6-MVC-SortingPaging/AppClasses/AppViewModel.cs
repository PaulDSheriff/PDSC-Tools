#nullable disable

using PDSC.Common;

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// All view model classes should inherit from this class
  /// Add any properties/methods that you require for each of the view models in your application
  /// For example, if each of your tables in your database has a common set of fields
  /// you could write code in here to set the default values for those fields.
  /// </summary>
  public class AppViewModel : ViewModelBase
  {
    #region Constructors
    public AppViewModel() : base()
    {
    }
    #endregion

    #region Public Properties
   
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();

      // TODO: Initialize any of your properties here

    }
    #endregion
  }
}