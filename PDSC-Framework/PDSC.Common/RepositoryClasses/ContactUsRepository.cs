using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class ContactUsRepository : IRepository<ContactUs, ContactUsSearch>
  {
    #region Constructor
    public ContactUsRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public ContactUs Get(int id)
    {
      return _DbContext.ContactUsList.Where(p => p.ContactUsId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<ContactUs> Search(ContactUsSearch entity)
    {
      IQueryable<ContactUs> query = _DbContext.ContactUsList;

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
    public IQueryable<ContactUs> AddWhereClause(IQueryable<ContactUs> query, ContactUsSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.FirstName) ? true : x.FirstName.StartsWith(entity.FirstName))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<ContactUs> AddOrderByClause(IQueryable<ContactUs> query, ContactUsSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "firstname_asc":
          query = query.OrderBy(x => x.FirstName);
          break;
        case "firstname_desc":
          query = query.OrderByDescending(x => x.FirstName);
          break;
        case "lastname_asc":
          query = query.OrderBy(x => x.LastName);
          break;
        case "lastname_desc":
          query = query.OrderByDescending(x => x.LastName);
          break;
        case "emailaddress_asc":
          query = query.OrderBy(x => x.EmailAddress);
          break;
        case "emailaddress_desc":
          query = query.OrderByDescending(x => x.EmailAddress);
          break;
        case "phone_asc":
          query = query.OrderBy(x => x.Phone);
          break;
        case "phone_desc":
          query = query.OrderByDescending(x => x.Phone);
          break;
        case "contacttext_asc":
          query = query.OrderBy(x => x.ContactText);
          break;
        case "contacttext_desc":
          query = query.OrderByDescending(x => x.ContactText);
          break;
        case "ipaddress_asc":
          query = query.OrderBy(x => x.IPAddress);
          break;
        case "ipaddress_desc":
          query = query.OrderByDescending(x => x.IPAddress);
          break;
        case "respondedbyname_asc":
          query = query.OrderBy(x => x.RespondedByName);
          break;
        case "respondedbyname_desc":
          query = query.OrderByDescending(x => x.RespondedByName);
          break;
        case "respondeddate_asc":
          query = query.OrderBy(x => x.RespondedDate);
          break;
        case "respondeddate_desc":
          query = query.OrderByDescending(x => x.RespondedDate);
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
    public IQueryable<ContactUs> AddPaging(IQueryable<ContactUs> query, ContactUsSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(ContactUsSearch entity)
    {
      // Perform Searching
       return _DbContext.ContactUsList.Where(x =>
          (string.IsNullOrEmpty(entity.FirstName) ? true : x.FirstName.StartsWith(entity.FirstName))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual ContactUs CreateEmpty()
    {
      return new ContactUs
      {
        ContactUsId = null
        ,FirstName = null
        ,LastName = null
        ,EmailAddress = null
        ,Phone = null
        ,ContactText = null
        ,IPAddress = null
        ,RespondedByName = null
        ,RespondedDate = null
        ,IsActive = false
      };
    }
    #endregion

    #region Insert Method
    public virtual ContactUs Insert(ContactUs entity)
    {
      // Add new entity to ContactUs DbSet
      _DbContext.ContactUsList.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual ContactUs Update(ContactUs entity)
    {
      // Update entity in ContactUs DbSet
      _DbContext.ContactUsList.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the ContactUss DbSet
      _DbContext.ContactUsList.Remove(_DbContext.ContactUsList.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
