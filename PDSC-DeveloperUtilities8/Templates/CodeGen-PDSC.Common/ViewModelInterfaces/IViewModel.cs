using System.Collections.ObjectModel;

namespace PDSC.Common;

/// <summary>
/// Interface for all view model classes.
/// </summary>
/// <typeparam name="TEntity">An entity class</typeparam>
/// <typeparam name="TSearch">A search entity class</typeparam>
public interface IViewModel<TEntity, TSearch> where TEntity : class
{
  Task<DataResponse<ObservableCollection<TEntity>>> GetAsync();
  Task<DataResponse<TEntity>> GetAsync(int id);

  Task<DataResponse<ObservableCollection<TEntity>>> SearchAsync();
  Task<DataResponse<ObservableCollection<TEntity>>> SearchAsync(TSearch search);

  Task<DataResponse<TEntity>> SaveAsync();

  Task<DataResponse<TEntity>> InsertAsync();
  Task<DataResponse<TEntity>> InsertAsync(TEntity? entity);

  Task<DataResponse<TEntity>> UpdateAsync();
  Task<DataResponse<TEntity>> UpdateAsync(int id, TEntity? entity);

  Task<DataResponse<TEntity>> DeleteAsync(int id);

  Task<DataResponse<int>> CountAsync(TSearch? search);
}
