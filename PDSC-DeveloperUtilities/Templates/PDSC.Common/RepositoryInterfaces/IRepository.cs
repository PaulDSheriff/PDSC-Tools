namespace PDSC.Common
{
  public interface IRepository<TEntity, TSearch> : IRepositoryBase<TEntity, TSearch>
  {
    TEntity Get(int id);
    bool Delete(int id);
  }
}