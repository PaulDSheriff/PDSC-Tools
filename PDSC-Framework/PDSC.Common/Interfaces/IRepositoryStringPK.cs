namespace PDSC.Common
{
  /// <summary>
  /// This interface contains those methods needed for tables with a 'string' primary key
  /// </summary>
  /// <typeparam name="TEntity">The Entity type</typeparam>
  /// <typeparam name="TSearch">The Search type</typeparam>
  public interface IRepositoryStringPK<TEntity, TSearch> : IRepositoryBase<TEntity, TSearch>
  {
    TEntity Get(string id);
    bool Delete(string id);
  }
}