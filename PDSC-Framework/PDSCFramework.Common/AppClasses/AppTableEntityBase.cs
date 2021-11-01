using PDSC.Common;

namespace PDSCFramework.Common
{
  /// <summary>
  /// All your Entity Framework entity classes that have an 'int' primary key should inherit from this class
  /// NOTE: This class can either inherit from TableEntityBase or EntityBase
  ///       in the PDSC.Common namespace
  /// </summary>
  public class AppTableEntityBase : TableEntityBase
  {
  }
}
