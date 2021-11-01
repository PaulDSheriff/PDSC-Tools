using System.Linq;
using PDSC.Common;
using PDSCFramework.EntityLayer;

namespace PDSCFramework.DataLayer
{
  public partial class PersonRepository : IRepository<Person, PersonSearch>
  {
    #region Constructor
    public PersonRepository(ApplicationDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly ApplicationDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public Person Get(int id)
    {
      return _DbContext.People.Where(p => p.PersonId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<Person> Search(PersonSearch entity)
    {
      IQueryable<Person> query = _DbContext.People;

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
    public IQueryable<Person> AddWhereClause(IQueryable<Person> query, PersonSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.FirstName) ? true : x.FirstName.StartsWith(entity.FirstName))
          &&  (string.IsNullOrEmpty(entity.LastName) ? true : x.LastName.StartsWith(entity.LastName))
          &&  (string.IsNullOrEmpty(entity.EmailAddress) ? true : x.EmailAddress.StartsWith(entity.EmailAddress))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<Person> AddOrderByClause(IQueryable<Person> query, PersonSearch entity)
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
        case "cellphone_asc":
          query = query.OrderBy(x => x.CellPhone);
          break;
        case "cellphone_desc":
          query = query.OrderByDescending(x => x.CellPhone);
          break;
        case "city_asc":
          query = query.OrderBy(x => x.City);
          break;
        case "city_desc":
          query = query.OrderByDescending(x => x.City);
          break;
        case "statecode_asc":
          query = query.OrderBy(x => x.StateCode);
          break;
        case "statecode_desc":
          query = query.OrderByDescending(x => x.StateCode);
          break;
        case "isactive_asc":
          query = query.OrderBy(x => x.IsActive);
          break;
        case "isactive_desc":
          query = query.OrderByDescending(x => x.IsActive);
          break;
        case "persontypeid_asc":
          query = query.OrderBy(x => x.PersonTypeId);
          break;
        case "persontypeid_desc":
          query = query.OrderByDescending(x => x.PersonTypeId);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<Person> AddPaging(IQueryable<Person> query, PersonSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(PersonSearch entity)
    {
      // Perform Searching
       return _DbContext.People.Where(x =>
          (string.IsNullOrEmpty(entity.FirstName) ? true : x.FirstName.StartsWith(entity.FirstName))
          &&  (string.IsNullOrEmpty(entity.LastName) ? true : x.LastName.StartsWith(entity.LastName))
          &&  (string.IsNullOrEmpty(entity.EmailAddress) ? true : x.EmailAddress.StartsWith(entity.EmailAddress))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual Person CreateEmpty()
    {
      return new Person
      {
        PersonId = null
        ,AspNetUsersId = null
        ,FirstName = null
        ,LastName = null
        ,EmailAddress = null
        ,HomePhone = null
        ,CellPhone = null
        ,Street1 = null
        ,Street2 = null
        ,Street3 = null
        ,City = null
        ,Village = null
        ,StateCode = null
        ,ProvinceCode = null
        ,PostalCode = null
        ,CountryCode = null
        ,SiteTermsId = null
        ,DateTermsAccepted = null
        ,IsActive = false
        ,OkToSendEmails = false
        ,PersonTypeId = null
      };
    }
    #endregion

    #region Insert Method
    public virtual Person Insert(Person entity)
    {
      // Add new entity to People DbSet
      _DbContext.People.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual Person Update(Person entity)
    {
      // Update entity in People DbSet
      _DbContext.People.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the Persons DbSet
      _DbContext.People.Remove(_DbContext.People.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
