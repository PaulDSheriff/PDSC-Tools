using PDSC.Common;

namespace <|NAMESPACE|>.Common {
  /// <summary>
  /// All your Entity Framework entity classes should inherit from this class
  /// If you have a standard fields in each table in your database, add those here
  /// </summary>
  public class AppEntity : EntityBase
  {
    #region Properties
    // TODO: Add any standard fields here
    #endregion

    #region Init Method
    public override void Init() {
      base.Init();

      // TODO: Initialize your standard fields here
    }
    #endregion
  }
}
