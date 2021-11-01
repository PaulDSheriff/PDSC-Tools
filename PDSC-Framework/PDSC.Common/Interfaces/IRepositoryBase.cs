using System.Linq;

namespace PDSC.Common
{
  /// <summary>
  /// This base interface contains those methods common to all repositories
  /// </summary>
  /// <typeparam name="TEntity">The Entity type</typeparam>
  /// <typeparam name="TSearch">The Search type</typeparam>
  public interface IRepositoryBase<TEntity, TSearch>
  {
    IQueryable<TEntity> Search(TSearch search);
    public IQueryable<TEntity> AddWhereClause(IQueryable<TEntity> query, TSearch entity);
    public IQueryable<TEntity> AddOrderByClause(IQueryable<TEntity> query, TSearch entity);
    public IQueryable<TEntity> AddPaging(IQueryable<TEntity> query, TSearch entity);
    TEntity CreateEmpty();
    TEntity Insert(TEntity entity);
    TEntity Update(TEntity entity);
    int Count(TSearch entity);
  }
}