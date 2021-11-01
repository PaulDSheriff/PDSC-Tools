namespace PDSC.Common
{
  /// <summary>
  /// All entity classes with a 'int' primary key should ultimately inherit from this class
  /// </summary>
  public class EntityBase
  {
    public EntityBase()
    {
      Init();
    }

    public virtual void Init()
    {
    }
  }
}
