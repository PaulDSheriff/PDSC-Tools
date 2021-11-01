using System.Linq;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class CountryRepository : IRepositoryStringPK<Country, CountrySearch>
  {
    #region Constructor
    public CountryRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public Country Get(string id)
    {
      return _DbContext.Countries.Where(p => p.CountryCode == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<Country> Search(CountrySearch entity)
    {
      IQueryable<Country> query = _DbContext.Countries;

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
    public IQueryable<Country> AddWhereClause(IQueryable<Country> query, CountrySearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.CountryName) ? true : x.CountryName.StartsWith(entity.CountryName))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<Country> AddOrderByClause(IQueryable<Country> query, CountrySearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "countrycode_asc":
          query = query.OrderBy(x => x.CountryCode);
          break;
        case "countrycode_desc":
          query = query.OrderByDescending(x => x.CountryCode);
          break;
        case "countryname_asc":
          query = query.OrderBy(x => x.CountryName);
          break;
        case "countryname_desc":
          query = query.OrderByDescending(x => x.CountryName);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<Country> AddPaging(IQueryable<Country> query, CountrySearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(CountrySearch entity)
    {
      // Perform Searching
       return _DbContext.Countries.Where(x =>
          (string.IsNullOrEmpty(entity.CountryName) ? true : x.CountryName.StartsWith(entity.CountryName))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual Country CreateEmpty()
    {
      return new Country
      {
        CountryCode = null
        ,CountryName = null
      };
    }
    #endregion

    #region Insert Method
    public virtual Country Insert(Country entity)
    {
      // Add new entity to Countries DbSet
      _DbContext.Countries.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual Country Update(Country entity)
    {
      // Update entity in Countries DbSet
      _DbContext.Countries.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(string id)
    {
      // Locate the entity to delete in the Countrys DbSet
      _DbContext.Countries.Remove(_DbContext.Countries.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
