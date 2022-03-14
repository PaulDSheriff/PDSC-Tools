using System.Linq;

namespace PDSC.Common
{
  public interface IRepositoryBase<TEntity, TSearch>
  {
    IQueryable<TEntity> Search(TSearch search);
    IQueryable<TEntity> AddWhereClause(IQueryable<TEntity> query, TSearch search);
    IQueryable<TEntity> AddOrderByClause(IQueryable<TEntity> query, TSearch search);
    IQueryable<TEntity> ApplyPaging(IQueryable<TEntity> query, TSearch search);
    int Count(TSearch search);
    TEntity CreateEmpty();
    TEntity Insert(TEntity entity);
    TEntity Update(TEntity entity);
  }
}