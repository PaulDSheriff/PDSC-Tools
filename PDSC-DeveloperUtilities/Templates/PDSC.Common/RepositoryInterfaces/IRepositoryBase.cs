using System.Linq;

namespace PDSC.Common
{
  public interface IRepositoryBase<TEntity, TSearch>
  {
    IQueryable<TEntity> Search(TSearch search);
    IQueryable<TEntity> AddWhereClause(IQueryable<TEntity> query, TSearch entity);
    IQueryable<TEntity> AddOrderByClause(IQueryable<TEntity> query, TSearch entity);
    TEntity CreateEmpty();
    TEntity Insert(TEntity entity);
    TEntity Update(TEntity entity);
  }
}