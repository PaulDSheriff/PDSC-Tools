using System.Collections.Generic;
using System.Linq;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class FAQRepository : IRepository<FAQ, FAQSearch>
  {
    #region Constructor
    public FAQRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public FAQ Get(int id)
    {
      return _DbContext.Faqs.Where(p => p.FAQId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<FAQ> Search(FAQSearch entity)
    {
      IQueryable<FAQ> query = _DbContext.Faqs;

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
    public IQueryable<FAQ> AddWhereClause(IQueryable<FAQ> query, FAQSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.FAQQuestion) ? true : x.FAQQuestion.StartsWith(entity.FAQQuestion))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<FAQ> AddOrderByClause(IQueryable<FAQ> query, FAQSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "faqquestion_asc":
          query = query.OrderBy(x => x.FAQQuestion);
          break;
        case "faqquestion_desc":
          query = query.OrderByDescending(x => x.FAQQuestion);
          break;
        case "faqanswer_asc":
          query = query.OrderBy(x => x.FAQAnswer);
          break;
        case "faqanswer_desc":
          query = query.OrderByDescending(x => x.FAQAnswer);
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
    public IQueryable<FAQ> AddPaging(IQueryable<FAQ> query, FAQSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(FAQSearch entity)
    {
      // Perform Searching
       return _DbContext.Faqs.Where(x =>
          (string.IsNullOrEmpty(entity.FAQQuestion) ? true : x.FAQQuestion.StartsWith(entity.FAQQuestion))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual FAQ CreateEmpty()
    {
      return new FAQ
      {
        FAQId = null
        ,FAQQuestion = null
        ,FAQAnswer = null
        ,IsActive = false
      };
    }
    #endregion

    #region Insert Method
    public virtual FAQ Insert(FAQ entity)
    {
      // Add new entity to Faqs DbSet
      _DbContext.Faqs.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual FAQ Update(FAQ entity)
    {
      // Update entity in Faqs DbSet
      _DbContext.Faqs.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the FAQs DbSet
      _DbContext.Faqs.Remove(_DbContext.Faqs.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
