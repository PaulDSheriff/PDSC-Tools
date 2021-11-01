using PDSC.Common;

namespace PDSCFramework.Common
{
  /// <summary>
  /// All your Entity Framework entity classes that have a 'string' primary key should inherit from this class
  /// NOTE: This class can either inherit from TableEntityBaseStringPK or EntityBaseStringPK
  ///       in the PDSC.Common namespace
  /// </summary>
  public class AppTableEntityStringPKBase : TableEntityBaseStringPK
  {
  }
}
