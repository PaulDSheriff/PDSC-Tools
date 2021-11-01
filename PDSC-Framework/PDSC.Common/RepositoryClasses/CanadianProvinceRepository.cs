using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class CanadianProvinceRepository : IRepositoryStringPK<CanadianProvince, CanadianProvinceSearch>
  {
    #region Constructor
    public CanadianProvinceRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public CanadianProvince Get(string id)
    {
      return _DbContext.CanadianProvinces.Where(p => p.ProvinceCode == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<CanadianProvince> Search(CanadianProvinceSearch entity)
    {
      IQueryable<CanadianProvince> query = _DbContext.CanadianProvinces;

      // Add WHERE clause(s)
      query = AddWhereClause(query, entity);

      // Add ORDER BY clause(s)
      query = AddOrderByClause(query, entity);

      // Setup Paging
      query = AddPaging(query, entity);

      // Return query
      return query;     
    }
    #endregion
    
    #region AddWhereClause Method
    public IQueryable<CanadianProvince> AddWhereClause(IQueryable<CanadianProvince> query, CanadianProvinceSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.ProvinceName) ? true : x.ProvinceName.StartsWith(entity.ProvinceName))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<CanadianProvince> AddOrderByClause(IQueryable<CanadianProvince> query, CanadianProvinceSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "provincecode_asc":
          query = query.OrderBy(x => x.ProvinceCode);
          break;
        case "provincecode_desc":
          query = query.OrderByDescending(x => x.ProvinceCode);
          break;
        case "provincename_asc":
          query = query.OrderBy(x => x.ProvinceName);
          break;
        case "provincename_desc":
          query = query.OrderByDescending(x => x.ProvinceName);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<CanadianProvince> AddPaging(IQueryable<CanadianProvince> query, CanadianProvinceSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(CanadianProvinceSearch entity)
    {
      // Perform Searching
       return _DbContext.CanadianProvinces.Where(x =>
          (string.IsNullOrEmpty(entity.ProvinceName) ? true : x.ProvinceName.StartsWith(entity.ProvinceName))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual CanadianProvince CreateEmpty()
    {
      return new CanadianProvince
      {
        ProvinceCode = null
        ,ProvinceName = null
      };
    }
    #endregion

    #region Insert Method
    public virtual CanadianProvince Insert(CanadianProvince entity)
    {
      // Add new entity to CanadianProvinces DbSet
      _DbContext.CanadianProvinces.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual CanadianProvince Update(CanadianProvince entity)
    {
      // Update entity in CanadianProvinces DbSet
      _DbContext.CanadianProvinces.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(string id)
    {
      // Locate the entity to delete in the CanadianProvinces DbSet
      _DbContext.CanadianProvinces.Remove(_DbContext.CanadianProvinces.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
