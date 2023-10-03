namespace PDSC.Common;

/// <summary>
/// Interface for all repository classes when the primary key data type is other than 'int'
/// </summary>
/// <typeparam name="TPK">Primary Key Data Type (string, guid, etc.)</typeparam>
/// <typeparam name="TEntity">An entity class</typeparam>
/// <typeparam name="TSearch">A search entity class</typeparam>
public interface IRepositoryOtherPK<TPK, TEntity, TSearch>
{
  DataResponseBase? ResponseObject { get; set; }

  Task<List<TEntity>> GetAsync();
  Task<TEntity?> GetAsync(TPK id);
  Task<List<TEntity>> SearchAsync(TSearch search);

  Task<int> CountAsync(TSearch search);

  Task<TEntity?> InsertAsync(TEntity? entity);
  Task<TEntity?> UpdateAsync(TEntity? entity);
  Task<bool?> DeleteAsync(TEntity? entity);
}