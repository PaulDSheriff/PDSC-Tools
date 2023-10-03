using System.Collections.ObjectModel;

namespace PDSC.Common;

/// <summary>
/// This interface is used for all view models that have a primary key of anything other than an 'int' data type.
/// </summary>
/// <typeparam name="TPK">Primary Key Data Type (string, guid, etc.)</typeparam>
/// <typeparam name="TEntity">An entity class</typeparam>
/// <typeparam name="TSearch">A search entity class</typeparam>
public interface IViewModelOtherPK<TPK, TEntity, TSearch> where TEntity : class where TSearch : class
{
  Task<DataResponse<ObservableCollection<TEntity>>> GetAsync();
  Task<DataResponse<TEntity>> GetAsync(TPK id);

  Task<DataResponse<ObservableCollection<TEntity>>> SearchAsync();
  Task<DataResponse<ObservableCollection<TEntity>>> SearchAsync(TSearch search);

  Task<DataResponse<TEntity>> InsertAsync();
  Task<DataResponse<TEntity>> InsertAsync(TEntity? entity);

  Task<DataResponse<TEntity>> UpdateAsync();
  Task<DataResponse<TEntity>> UpdateAsync(TPK id, TEntity? entity);
  Task<DataResponse<TEntity>> DeleteAsync(TPK id);

  Task<DataResponse<int>> CountAsync(TSearch? search);
}
