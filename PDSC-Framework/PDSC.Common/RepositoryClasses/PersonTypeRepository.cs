using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class PersonTypeRepository : IRepository<PersonType, PersonTypeSearch>
  {
    #region Constructor
    public PersonTypeRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public PersonType Get(int id)
    {
      return _DbContext.PersonTypes.Where(p => p.PersonTypeId == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<PersonType> Search(PersonTypeSearch entity)
    {
      IQueryable<PersonType> query = _DbContext.PersonTypes;

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
    public IQueryable<PersonType> AddWhereClause(IQueryable<PersonType> query, PersonTypeSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.TypeDescription) ? true : x.TypeDescription.StartsWith(entity.TypeDescription))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<PersonType> AddOrderByClause(IQueryable<PersonType> query, PersonTypeSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "typedescription_asc":
          query = query.OrderBy(x => x.TypeDescription);
          break;
        case "typedescription_desc":
          query = query.OrderByDescending(x => x.TypeDescription);
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
    public IQueryable<PersonType> AddPaging(IQueryable<PersonType> query, PersonTypeSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(PersonTypeSearch entity)
    {
      // Perform Searching
       return _DbContext.PersonTypes.Where(x =>
          (string.IsNullOrEmpty(entity.TypeDescription) ? true : x.TypeDescription.StartsWith(entity.TypeDescription))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual PersonType CreateEmpty()
    {
      return new PersonType
      {
        PersonTypeId = null
        ,TypeDescription = null
        ,IsActive = false
      };
    }
    #endregion

    #region Insert Method
    public virtual PersonType Insert(PersonType entity)
    {
      // Add new entity to PersonTypes DbSet
      _DbContext.PersonTypes.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual PersonType Update(PersonType entity)
    {
      // Update entity in PersonTypes DbSet
      _DbContext.PersonTypes.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the PersonTypes DbSet
      _DbContext.PersonTypes.Remove(_DbContext.PersonTypes.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
