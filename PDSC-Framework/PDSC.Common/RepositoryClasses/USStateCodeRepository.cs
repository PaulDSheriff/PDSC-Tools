using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class USStateCodeRepository : IRepositoryStringPK<USStateCode, USStateCodeSearch>
  {
    #region Constructor
    public USStateCodeRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public USStateCode Get(string id)
    {
      return _DbContext.USStateCodes.Where(p => p.StateCode == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<USStateCode> Search(USStateCodeSearch entity)
    {
      IQueryable<USStateCode> query = _DbContext.USStateCodes;

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
    public IQueryable<USStateCode> AddWhereClause(IQueryable<USStateCode> query, USStateCodeSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.StateName) ? true : x.StateName.StartsWith(entity.StateName))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<USStateCode> AddOrderByClause(IQueryable<USStateCode> query, USStateCodeSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "statecode_asc":
          query = query.OrderBy(x => x.StateCode);
          break;
        case "statecode_desc":
          query = query.OrderByDescending(x => x.StateCode);
          break;
        case "statename_asc":
          query = query.OrderBy(x => x.StateName);
          break;
        case "statename_desc":
          query = query.OrderByDescending(x => x.StateName);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<USStateCode> AddPaging(IQueryable<USStateCode> query, USStateCodeSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(USStateCodeSearch entity)
    {
      // Perform Searching
       return _DbContext.USStateCodes.Where(x =>
          (string.IsNullOrEmpty(entity.StateName) ? true : x.StateName.StartsWith(entity.StateName))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual USStateCode CreateEmpty()
    {
      return new USStateCode
      {
        StateCode = null
        ,StateName = null
      };
    }
    #endregion

    #region Insert Method
    public virtual USStateCode Insert(USStateCode entity)
    {
      // Add new entity to USStateCodes DbSet
      _DbContext.USStateCodes.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual USStateCode Update(USStateCode entity)
    {
      // Update entity in USStateCodes DbSet
      _DbContext.USStateCodes.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(string id)
    {
      // Locate the entity to delete in the USStateCodes DbSet
      _DbContext.USStateCodes.Remove(_DbContext.USStateCodes.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
