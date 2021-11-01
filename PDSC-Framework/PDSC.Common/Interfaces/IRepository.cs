using System.Linq;

namespace PDSC.Common
{
  /// <summary>
  /// This interface contains those methods needed for tables with an 'int' primary key
  /// </summary>
  /// <typeparam name="TEntity">The Entity type</typeparam>
  /// <typeparam name="TSearch">The Search type</typeparam>
  public interface IRepository<TEntity, TSearch> : IRepositoryBase<TEntity, TSearch>
  {
    TEntity Get(int id);
    bool Delete(int id);
  }
}