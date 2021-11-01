using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class EmailTemplateRepository : IRepository<EmailTemplate, EmailTemplateSearch>
  {
    #region Constructor
    public EmailTemplateRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public EmailTemplate Get(int id)
    {
      return _DbContext.EmailTemplates.Where(p => p.EmailTemplateId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<EmailTemplate> Search(EmailTemplateSearch entity)
    {
      IQueryable<EmailTemplate> query = _DbContext.EmailTemplates;

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
    public IQueryable<EmailTemplate> AddWhereClause(IQueryable<EmailTemplate> query, EmailTemplateSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.EmailTemplateName) ? true : x.EmailTemplateName.StartsWith(entity.EmailTemplateName))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<EmailTemplate> AddOrderByClause(IQueryable<EmailTemplate> query, EmailTemplateSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "emailtemplatename_asc":
          query = query.OrderBy(x => x.EmailTemplateName);
          break;
        case "emailtemplatename_desc":
          query = query.OrderByDescending(x => x.EmailTemplateName);
          break;
        case "emailsubject_asc":
          query = query.OrderBy(x => x.EmailSubject);
          break;
        case "emailsubject_desc":
          query = query.OrderByDescending(x => x.EmailSubject);
          break;
        case "emailtemplatetext_asc":
          query = query.OrderBy(x => x.EmailTemplateText);
          break;
        case "emailtemplatetext_desc":
          query = query.OrderByDescending(x => x.EmailTemplateText);
          break;
        case "isbodyhtml_asc":
          query = query.OrderBy(x => x.IsBodyHtml);
          break;
        case "isbodyhtml_desc":
          query = query.OrderByDescending(x => x.IsBodyHtml);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<EmailTemplate> AddPaging(IQueryable<EmailTemplate> query, EmailTemplateSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(EmailTemplateSearch entity)
    {
      // Perform Searching
       return _DbContext.EmailTemplates.Where(x =>
          (string.IsNullOrEmpty(entity.EmailTemplateName) ? true : x.EmailTemplateName.StartsWith(entity.EmailTemplateName))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual EmailTemplate CreateEmpty()
    {
      return new EmailTemplate
      {
        EmailTemplateId = null
        ,EmailTemplateName = null
        ,EmailSubject = null
        ,EmailTemplateText = null
        ,IsBodyHtml = false
      };
    }
    #endregion

    #region Insert Method
    public virtual EmailTemplate Insert(EmailTemplate entity)
    {
      // Add new entity to EmailTemplates DbSet
      _DbContext.EmailTemplates.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual EmailTemplate Update(EmailTemplate entity)
    {
      // Update entity in EmailTemplates DbSet
      _DbContext.EmailTemplates.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the EmailTemplates DbSet
      _DbContext.EmailTemplates.Remove(_DbContext.EmailTemplates.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
