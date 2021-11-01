using System;
using System.Collections.Generic;
using System.Linq;
using PDSC.Common;
using PDSCFramework.Common;
using PDSCFramework.DataLayer;
using PDSCFramework.EntityLayer;

namespace PDSCFramework.ViewModelLayer
{
  public class PersonViewModel : AppViewModelBase
  {
    #region Constructors
    /// <summary>
    ///  NOTE: You need to have a parameterless constructor for Post-Backs in MVC    
    /// </summary>
    public PersonViewModel() : base()
    {
      Init();
    }

    public PersonViewModel(IRepository<Person, PersonSearch> repository) : base()
    {
      Init();

      Repository = repository;
    }
    #endregion

    #region Properties
    public IRepository<Person, PersonSearch> Repository { get; set; }
    public List<Person> DataCollection { get; set; }
    public Person SelectedEntity { get; set; }
    public PersonSearch SearchEntity { get; set; }
    #endregion
    
    #region Init Method
    public override void Init()
    {
      base.Init();

      DataCollection = new List<Person>();
      SelectedEntity = new Person();
      SearchEntity = new PersonSearch();

      SortExpression = "LastName";
      SortExpressionPrevious = string.Empty;
    }
    #endregion

    #region Get(id) Method
    public override void Get(int id)
    {
      IsDetailVisible = true;
            
      if (Repository == null) {
        throw new ApplicationException("Must set the Repository property.");
      }
      else {
        SelectedEntity = Repository.Get(id);
      }

      if (SelectedEntity != null) {
        TotalRecords = 1;
      }       
    }
    #endregion
    
    #region Search Method
    public override void Search()
    {
      IsDetailVisible = false;
      
      // Store Search Data
      base.StoreSearchAsJson<PersonSearch>(SearchEntity);
      
      // Set Sort Property
      SearchEntity.SortExpression = base.SetSortProperties();
      
      // Setup the Pager object
      base.SetPagerObject(((PersonRepository)Repository).Count(SearchEntity));
      SearchEntity.PageSize = base.Pager.PageSize;
      SearchEntity.PageIndex = base.Pager.PageIndex;

      if (Repository == null) {
        throw new ApplicationException("Must set the Repository property.");
      }
      else {
        // Search for data
        DataCollection = Repository.Search(SearchEntity).ToList();
        // Get Record Count
        TotalRecords = Repository.Count(SearchEntity);
      }      
    }
    #endregion

    #region RestoreSearchFromJson Method
    public void RestoreSearchFromJson()
    {
      if (!string.IsNullOrEmpty(SearchAsJson)) {
        SearchEntity = base.RestoreSearchFromJson<PersonSearch>(SearchAsJson);
      }
    }
    #endregion

    #region CreateEmptyEntity Method
    public override void CreateEmptyEntity()
    {
      SelectedEntity = Repository.CreateEmpty();
    }
    #endregion

    #region Save Method
    public override bool Save()
    {
      bool ret = false;

      if (Validate()) {
        if (SelectedEntity.PersonId.HasValue) {
          // Set Tracking Fields
          SelectedEntity.UpdateName = LoginObject.EmailAddress;
          SelectedEntity.UpdateDate = DateTime.Now;

          // Update the current entity
          Repository.Update(SelectedEntity);
        }
        else {
          // Set Tracking Fields
          SelectedEntity.InsertName = LoginObject.EmailAddress;
          SelectedEntity.InsertDate = DateTime.Now;
          SelectedEntity.UpdateName = LoginObject.EmailAddress;
          SelectedEntity.UpdateDate = DateTime.Now;

          // Add a new entity
          Repository.Insert(SelectedEntity);
        }
        ret = true;
      }

      return ret;
    }
    #endregion
    
    #region Validate Method
    public override bool Validate()
    {
      IsValid = false;
      Messages = new List<string>();

      // TODO: Validate Your Properties Here

      IsValid = (Messages.Count == 0);

      return IsValid;
    }
    #endregion

    #region Delete Method
    public override bool Delete(int id)
    {
      // Delete the entity by id
      Repository.Delete(id);

      return true;
    }
    #endregion
  }
}
