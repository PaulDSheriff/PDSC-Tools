using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class PrivacyPolicyRepository : IRepository<PrivacyPolicy, PrivacyPolicySearch>
  {
    #region Constructor
    public PrivacyPolicyRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public PrivacyPolicy Get(int id)
    {
      return _DbContext.PrivacyPolicies.Where(p => p.PrivacyPolicyId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<PrivacyPolicy> Search(PrivacyPolicySearch entity)
    {
      IQueryable<PrivacyPolicy> query = _DbContext.PrivacyPolicies;

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
    public IQueryable<PrivacyPolicy> AddWhereClause(IQueryable<PrivacyPolicy> query, PrivacyPolicySearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.PrivacyText) ? true : x.PrivacyText.StartsWith(entity.PrivacyText))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<PrivacyPolicy> AddOrderByClause(IQueryable<PrivacyPolicy> query, PrivacyPolicySearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "privacytext_asc":
          query = query.OrderBy(x => x.PrivacyText);
          break;
        case "privacytext_desc":
          query = query.OrderByDescending(x => x.PrivacyText);
          break;
        case "isactive_asc":
          query = query.OrderBy(x => x.IsActive);
          break;
        case "isactive_desc":
          query = query.OrderByDescending(x => x.IsActive);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<PrivacyPolicy> AddPaging(IQueryable<PrivacyPolicy> query, PrivacyPolicySearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(PrivacyPolicySearch entity)
    {
      // Perform Searching
       return _DbContext.PrivacyPolicies.Where(x =>
          (string.IsNullOrEmpty(entity.PrivacyText) ? true : x.PrivacyText.StartsWith(entity.PrivacyText))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual PrivacyPolicy CreateEmpty()
    {
      return new PrivacyPolicy
      {
        PrivacyPolicyId = null
        ,PrivacyText = null
        ,IsActive = false
      };
    }
    #endregion

    #region Insert Method
    public virtual PrivacyPolicy Insert(PrivacyPolicy entity)
    {
      // Add new entity to PrivacyPolicies DbSet
      _DbContext.PrivacyPolicies.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual PrivacyPolicy Update(PrivacyPolicy entity)
    {
      // Update entity in PrivacyPolicies DbSet
      _DbContext.PrivacyPolicies.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the PrivacyPolicys DbSet
      _DbContext.PrivacyPolicies.Remove(_DbContext.PrivacyPolicies.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
