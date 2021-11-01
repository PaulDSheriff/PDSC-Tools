using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PDSC.Common;
using PDSCFramework.Common;
using PDSC.Common.EntityLayer;
using PDSC.Common.ViewModelLayer;

namespace PDSCFramework.Controllers
{
  [Area("PDSCLookups")]
  [Authorize(Roles = "Administrator")]
  public partial class SiteTermsController : AppControllerBase
   {
      #region Constructor
      /// <summary>
      /// Constructor for SiteTermsController class
      /// </summary>
      public SiteTermsController(AppSession session,
        AppSettings settings,
        IRepository<SiteTerms, SiteTermsSearch> repo) : base(session, settings)
      {
        _repo = repo;
      }
      #endregion

      #region Private Fields
      private readonly IRepository<SiteTerms, SiteTermsSearch> _repo;
      #endregion

      #region SiteTermsIndex Methods
      /// <summary>
      /// Executes when browser issues a Get request for /SiteTerms and 
      /// directs to the Index view
      /// </summary>
      /// <returns>An ActionResult that contains an instance of SiteTermsViewModel</returns>
      public ActionResult SiteTermsIndex()
      {
        // Create view model and pass in repository
        SiteTermsViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);
        
        // Restore Search Data
        vm.RestoreSearchFromJson();

        // Call method to load data
        vm.Search();

        return View(vm);
      }

      /// <summary>
      /// Handles the browser Post request for SiteTerms form
      /// </summary>
      /// <param name="vm">A SiteTermsViewModel instance for the entry</param>
      /// <returns>An ActionResult that either navigates to the index or stays on this view and displays errors</returns>
      [HttpPost]
      public ActionResult SiteTermsIndex(SiteTermsViewModel vm)
      {
        // Assign Repository to View Model
        vm.Repository = _repo;

        // Initialize View Model
        Init(vm);

        // Validate model and save data
        if (ModelState.IsValid) {
          // Save the Data
          vm.Save();

          // Redirect back to list
          return RedirectToAction("SiteTermsIndex");
        }
        else {
          vm.IsDetailVisible = true;

          return View(vm);
        }
      }
      #endregion
   
      #region Search Method
      [HttpGet]
      public IActionResult Search(SiteTermsViewModel vm)
      {
        // Assign Repository to View Model
        vm.Repository = _repo;

        // Initialize View Model
        Init(vm);
        
        // Reset Pager
        vm.ResetPagerProperties();

        // Call method to search for data
        vm.Search();

        return View("SiteTermsIndex", vm);
      }
      #endregion
   
      #region SortPage Method
      [HttpGet]
      public IActionResult SortPage(SiteTermsViewModel vm)
      {
        // Assign Repository to View Model
        vm.Repository = _repo;

        // Initialize View Model
        Init(vm);
                
        // Restore Search Data
        vm.RestoreSearchFromJson();

        // Call method to sort data
        vm.Search();

        // Reset model state to force new variables to be written
        ModelState.Clear();

        return View("SiteTermsIndex", vm);
      }
      #endregion

      #region Add Method
      [HttpGet]
      public IActionResult Add()
      {
        // Create view model and pass in repository
        SiteTermsViewModel vm = new(_repo)
        {
          IsDetailVisible = true
        };

        // Initialize View Model
        Init(vm);

        // Call method to create an empty entity to add
        vm.CreateEmptyEntity();
        
        return View("SiteTermsIndex", vm);
      }
      #endregion
   
      #region Edit Method
      [HttpGet]
      public IActionResult Edit(int id)
      {
        // Create view model and pass in repository
        SiteTermsViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to load a single record
        vm.Get(id);
        
        return View("SiteTermsIndex", vm);
      }
      #endregion
   
      #region Delete Method
      [HttpGet]
      public IActionResult Delete(int id)
      {
        // Create view model and pass in repository
        SiteTermsViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to delete a record
        vm.Delete(id);

        return RedirectToAction("SiteTermsIndex");
      }
      #endregion
   }
}
