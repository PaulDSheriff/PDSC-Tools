using System.ComponentModel.DataAnnotations.Schema;

namespace PDSC.Common
{
  /// <summary>
  /// All entity classes without an 'int' primary key should ultimately inherit from this class
  /// </summary>
  public class EntityBaseStringPK
  {
    [NotMapped]
    public bool IsAdding { get; set; }
  }
}