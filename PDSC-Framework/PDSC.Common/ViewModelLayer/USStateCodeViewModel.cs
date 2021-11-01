using System;
using System.Collections.Generic;
using System.Linq;
using PDSC.Common.EntityLayer;

namespace PDSC.Common.ViewModelLayer
{
  public partial class USStateCodeViewModel : ViewModelBaseStringPK
  {
    #region Constructors
    /// <summary>
    ///  NOTE: You need to have a parameterless constructor for Post-Backs in MVC    
    /// </summary>
    public USStateCodeViewModel() : base()
    {
      Init();
    }

    public USStateCodeViewModel(IRepositoryStringPK<USStateCode, USStateCodeSearch> repository) : base()
    {
      Init();

      Repository = repository;
    }
    #endregion

    #region Properties
    public IRepositoryStringPK<USStateCode, USStateCodeSearch> Repository { get; set; }
    public List<USStateCode> DataCollection { get; set; }
    public USStateCode SelectedEntity { get; set; }
    public USStateCodeSearch SearchEntity { get; set; }
    #endregion
    
    #region Init Method
    public override void Init()
    {
      base.Init();

      DataCollection = new List<USStateCode>();
      SelectedEntity = new USStateCode();
      SearchEntity = new USStateCodeSearch();

      SortExpression = "StateName";
      SortExpressionPrevious = string.Empty;
    }
    #endregion

    #region Get(id) Method
    public override void Get(string id)
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
      base.StoreSearchAsJson<USStateCodeSearch>(SearchEntity);
      
      // Set Sort Property
      SearchEntity.SortExpression = base.SetSortProperties();
      
      // Setup the Pager object
      base.SetPagerObject(Repository.Count(SearchEntity));
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
        SearchEntity = base.RestoreSearchFromJson<USStateCodeSearch>(SearchAsJson);
      }
    }
    #endregion

    #region CreateEmptyEntity Method
    public override void CreateEmptyEntity()
    {
      SelectedEntity = Repository.CreateEmpty();
      SelectedEntity.IsAdding = true;
    }
    #endregion

    #region Save Method
    public override bool Save()
    {
      bool ret = false;

      if (Validate()) {
        if (!SelectedEntity.IsAdding) {
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
    public override bool Delete(string id)
    {
      // Delete the entity by id
      Repository.Delete(id);

      return true;
    }
    #endregion
  }
}
