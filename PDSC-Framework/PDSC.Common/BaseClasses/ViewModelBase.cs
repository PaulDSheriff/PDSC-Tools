using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text.Json;
using PDSC.PagerClasses;

namespace PDSC.Common
{
  /// <summary>
  /// All view model classes whose repository class have a 'int' primary key should inherit from this class
  /// </summary>
  public class ViewModelBase : CommonBase
  {
    #region Constructors
    public ViewModelBase() : base()
    {
      Init();
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the set of settings for this application
    /// </summary>
    public ApplicationSettings AppSettings { get; set; }
    /// <summary>
    /// Get/Set the current user object
    /// </summary>
    public UserEntity LoginObject { get; set; }

    /// <summary>
    /// Get/Set a list of messages to display
    /// </summary>
    public List<string> Messages { get; set; }
    /// <summary>
    /// Get/Set the current message to display
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Get/Set if the detail area is visible
    /// </summary>
    public bool IsDetailVisible { get; set; }
    /// <summary>
    /// Get/Set if the current selected entity has passed all validation
    /// </summary>
    public bool IsValid { get; set; }
   
    /// <summary>
    /// Get/Set the current field to sort on
    /// </summary>
    public string SortExpression { get; set; }
    /// <summary>
    /// Get/Set the previous field that was sorted on
    /// </summary>
    public string SortExpressionPrevious { get; set; }
    /// <summary>
    /// Get/Set the current sort direction ("asc" or "desc")
    /// </summary>
    public string SortDirection { get; set; }

    /// <summary>
    /// Get/Set the last search
    /// </summary>
    public string SearchAsJson { get; set; }

    /// <summary>
    /// Get/Set # of records per page
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// Get/Set whether or not the pager is visible
    /// </summary>
    public bool IsPagerVisible { get; set; }
    /// <summary>
    /// Get/Set the Pager object
    /// </summary>
    public Pager Pager { get; set; }
    /// <summary>
    /// Get/Set the page collection
    /// </summary>
    public PagerItemCollection Pages { get; set; }
    /// <summary>
    /// Get/Set a list of page sizes to display to the user
    /// </summary>
    public List<int> PageSizes { get; set; }
    /// <summary>
    /// Get/Set the current page command 
    /// such as 'first', 'next', 'last', 'previous', or a page number
    /// </summary>
    public string PageCommand { get; set; }
    /// <summary>
    /// Get/Set total number of records returned from the last query
    /// </summary>
    public int TotalRecords { get; set; }

    private IPrincipal _CurrentPrincipal = null;
    /// <summary>
    /// Get/Set the current principal object
    /// </summary>
    public IPrincipal CurrentPrincipal
    {
      get { return _CurrentPrincipal; }
      set {
        _CurrentPrincipal = value;
        if (_CurrentPrincipal != null && _CurrentPrincipal.Identity != null) {
          if (string.IsNullOrEmpty(_CurrentPrincipal.Identity.Name)) {
            LoginObject.LoginName = PDSCConstants.DEFAULT_LOGIN_NAME;
          }
          else {
            LoginObject.LoginName = _CurrentPrincipal.Identity.Name;
          }
        }
      }
    }
    #endregion

    #region Init Method
    public override void Init()
    {
      base.Init();

      IsDetailVisible = false;
      IsValid = false;

      AppSettings = new ApplicationSettings();
      LoginObject = new UserEntity();

      Messages = new List<string>();
      Message = string.Empty;

      SortExpression = string.Empty;
      SortExpressionPrevious = string.Empty;
      SortDirection = "asc";

      Pager = new Pager();
      IsPagerVisible = true;
      PageSize = 10;
      PageSizes = new List<int>
      {
        10,
        25,
        50,
        100
      };

      TotalRecords = 0;
    }
    #endregion

    #region CRUD Methods   
    public virtual void Get(int id)
    {
    }

    public virtual void Get(string id)
    {
    }

    public virtual void Search()
    {
    }

    public virtual bool Save()
    {
      return true;
    }

    public virtual bool Delete(int id)
    {
      return true;
    }

    public virtual bool Delete(string id)
    {
      return true;
    }
    #endregion

    #region Validate Method
    public virtual bool Validate()
    {
      return true;
    }
    #endregion

    #region StoreSearchAsJson Method
    public virtual void StoreSearchAsJson<T>(T value)
    {
      SearchAsJson = JsonSerializer.Serialize(value);
    }
    #endregion

    #region RestoreSearchFromJson Method
    public virtual T RestoreSearchFromJson<T>(string value)
    {
      return JsonSerializer.Deserialize<T>(value);
    }
    #endregion

    #region Sort Method
    public virtual void Sort()
    {
    }
    #endregion

    #region Page Method
    public virtual void Page()
    {
    }
    #endregion

    #region SetSortProperties Method
    protected virtual string SetSortProperties()
    {
      string ret;

      // If not paging, do the sorting
      if (string.IsNullOrEmpty(PageCommand)) {
        // See if sort expression is same as previous one
        if (SortExpression == SortExpressionPrevious) {
          ret = (SortExpression + (SortDirection == "asc" ? "_desc" : "_asc")).ToLower();
          SortDirection = SortDirection == "asc" ? "desc" : "asc";
        }
        else {
          ret = SortExpression.ToLower() + "_asc";
          SortDirection = "asc";
        }

        // Set Previous Expression
        SortExpressionPrevious = SortExpression;
      }
      else {
        // If paging, just return the current sort stuff
        ret = SortExpression.ToLower() + "_" + SortDirection;
      }

      return ret;
    }
    #endregion

    #region SetPagerObject Method
    protected virtual void SetPagerObject(int totalRecords)
    {
      // Set Pager Information
      Pager.TotalRecords = totalRecords;
      Pager.PageSize = PageSize;

      // Set Pager Properties
      Pager.SetPagerProperties(PageCommand);

      // Build paging collection
      Pages = new PagerItemCollection(Pager);
     
      // Reset PageCommand
      PageCommand = string.Empty;
    }
    #endregion

    #region ResetPagerProperties Method
    public virtual void ResetPagerProperties()
    {
      // Set Pager Information
      Pager = new Pager();
      PageCommand = string.Empty;
    }
    #endregion

    #region CreateEmptyEntity Method
    public virtual void CreateEmptyEntity()
    {
    }
    #endregion

    #region PublishException Method
    public virtual void PublishException(Exception ex)
    {
      LastException = ex;
      LastErrorMessage = ex.Message;

      // TODO: Publish Exception
      System.Diagnostics.Debug.Write(ex.ToString());
    }
    #endregion
  }
}