using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class SiteTermsRepository : IRepository<SiteTerms, SiteTermsSearch>
  {
    #region Constructor
    public SiteTermsRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public SiteTerms Get(int id)
    {
      return _DbContext.SiteTerms.Where(p => p.SiteTermsId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<SiteTerms> Search(SiteTermsSearch entity)
    {
      IQueryable<SiteTerms> query = _DbContext.SiteTerms;

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
    public IQueryable<SiteTerms> AddWhereClause(IQueryable<SiteTerms> query, SiteTermsSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.TermsText) ? true : x.TermsText.StartsWith(entity.TermsText))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<SiteTerms> AddOrderByClause(IQueryable<SiteTerms> query, SiteTermsSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "termstext_asc":
          query = query.OrderBy(x => x.TermsText);
          break;
        case "termstext_desc":
          query = query.OrderByDescending(x => x.TermsText);
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
    public IQueryable<SiteTerms> AddPaging(IQueryable<SiteTerms> query, SiteTermsSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(SiteTermsSearch entity)
    {
      // Perform Searching
       return _DbContext.SiteTerms.Where(x =>
          (string.IsNullOrEmpty(entity.TermsText) ? true : x.TermsText.StartsWith(entity.TermsText))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual SiteTerms CreateEmpty()
    {
      return new SiteTerms
      {
        SiteTermsId = null
        ,TermsText = null
        ,IsActive = false
      };
    }
    #endregion

    #region Insert Method
    public virtual SiteTerms Insert(SiteTerms entity)
    {
      // Add new entity to SiteTerms DbSet
      _DbContext.SiteTerms.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual SiteTerms Update(SiteTerms entity)
    {
      // Update entity in SiteTerms DbSet
      _DbContext.SiteTerms.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the SiteTermss DbSet
      _DbContext.SiteTerms.Remove(_DbContext.SiteTerms.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
