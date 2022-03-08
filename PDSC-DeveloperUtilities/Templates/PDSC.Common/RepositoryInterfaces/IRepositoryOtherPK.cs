namespace PDSC.Common
{
  public interface IRepositoryOtherPK<TPK, TEntity, TSearch> : IRepositoryBase<TEntity, TSearch>
  {
    TEntity Get(TPK id);
    bool Delete(TPK id);
  }
}