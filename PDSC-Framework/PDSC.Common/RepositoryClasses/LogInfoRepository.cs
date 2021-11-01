using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class LogInfoRepository : IRepository<LogInfo, LogInfoSearch>
  {
    #region Constructor
    public LogInfoRepository(PDSCDbContext context)
    {
	      _DbContext = context;
    }
    #endregion

    #region Protected Properties
    protected readonly PDSCDbContext _DbContext;
    #endregion

    #region Get(id) Method
    public LogInfo Get(int id)
    {
      return _DbContext.LogInfoList.Where(p => p.Id == id).FirstOrDefault();
    }
    #endregion

    #region Search Method
    public IQueryable<LogInfo> Search(LogInfoSearch entity)
    {
      IQueryable<LogInfo> query = _DbContext.LogInfoList;

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
    public IQueryable<LogInfo> AddWhereClause(IQueryable<LogInfo> query, LogInfoSearch entity)
    {     
      // Perform Searching
      query = query.Where(x =>
          (string.IsNullOrEmpty(entity.Message) ? true : x.Message.StartsWith(entity.Message))
          );

      return query;
    }
    #endregion
    
    #region AddOrderByClause Method
    public IQueryable<LogInfo> AddOrderByClause(IQueryable<LogInfo> query, LogInfoSearch entity)
    {      
      // Determine how to sort the data
      switch (entity.SortExpression) {
        case "message_asc":
          query = query.OrderBy(x => x.Message);
          break;
        case "message_desc":
          query = query.OrderByDescending(x => x.Message);
          break;
        case "messagetemplate_asc":
          query = query.OrderBy(x => x.MessageTemplate);
          break;
        case "messagetemplate_desc":
          query = query.OrderByDescending(x => x.MessageTemplate);
          break;
        case "level_asc":
          query = query.OrderBy(x => x.Level);
          break;
        case "level_desc":
          query = query.OrderByDescending(x => x.Level);
          break;
        case "timestamp_asc":
          query = query.OrderBy(x => x.TimeStamp);
          break;
        case "timestamp_desc":
          query = query.OrderByDescending(x => x.TimeStamp);
          break;
        case "exception_asc":
          query = query.OrderBy(x => x.Exception);
          break;
        case "exception_desc":
          query = query.OrderByDescending(x => x.Exception);
          break;
        case "properties_asc":
          query = query.OrderBy(x => x.Properties);
          break;
        case "properties_desc":
          query = query.OrderByDescending(x => x.Properties);
          break;
      }

      return query;
    }
    #endregion
        
    #region AddPaging Method
    public IQueryable<LogInfo> AddPaging(IQueryable<LogInfo> query, LogInfoSearch entity)
    {
      query = query.Skip(entity.PageIndex *
                          entity.PageSize)
                   .Take(entity.PageSize);

      return query;
    }
    #endregion

    #region Count Method
    public int Count(LogInfoSearch entity)
    {
      // Perform Searching
       return _DbContext.LogInfoList.Where(x =>
          (string.IsNullOrEmpty(entity.Message) ? true : x.Message.StartsWith(entity.Message))
          ).Count();
    }
    #endregion

    #region CreateEmpty Method
    public virtual LogInfo CreateEmpty()
    {
      return new LogInfo
      {
        Id = null
        ,Message = null
        ,MessageTemplate = null
        ,Level = null
        ,TimeStamp = null
        ,Exception = null
        ,Properties = null
      };
    }
    #endregion

    #region Insert Method
    public virtual LogInfo Insert(LogInfo entity)
    {
      // Add new entity to LogInfo DbSet
      _DbContext.LogInfoList.Add(entity);

      // Save changes in database
      _DbContext.SaveChanges();
      
      return entity;
    }
    #endregion

    #region Update Method
    public virtual LogInfo Update(LogInfo entity)
    {
      // Update entity in LogInfo DbSet
      _DbContext.LogInfoList.Update(entity);

      // Save changes in database
      _DbContext.SaveChanges();
     
      return entity;
    }
    #endregion

    #region Delete Method
    public virtual bool Delete(int id)
    {
      // Locate the entity to delete in the LogInfos DbSet
      _DbContext.LogInfoList.Remove(_DbContext.LogInfoList.Find(id));

      // Save changes in database
      _DbContext.SaveChanges();
      
      return true;
    }
    #endregion
  }
}
