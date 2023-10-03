namespace PDSC.Common;

/// <summary>
/// Interface for all repository classes
/// </summary>
/// <typeparam name="TEntity">An entity class</typeparam>
/// <typeparam name="TSearch">A search entity class</typeparam>
public interface IRepository<TEntity, TSearch>
{
  DataResponseBase? ResponseObject { get; set; }

  Task<List<TEntity>> GetAsync();
  Task<TEntity?> GetAsync(int id);
  Task<List<TEntity>> SearchAsync(TSearch search);

  Task<int> CountAsync(TSearch search);

  Task<TEntity?> InsertAsync(TEntity? entity);
  Task<TEntity?> UpdateAsync(TEntity? entity);
  Task<bool?> DeleteAsync(TEntity? entity);
}