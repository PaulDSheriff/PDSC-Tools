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
  public partial class PrivacyPolicyController : AppControllerBase
   {
      #region Constructor
      /// <summary>
      /// Constructor for PrivacyPolicyController class
      /// </summary>
      public PrivacyPolicyController(AppSession session,
        AppSettings settings,
        IRepository<PrivacyPolicy, PrivacyPolicySearch> repo) : base(session, settings)
      {
        _repo = repo;
      }
      #endregion

      #region Private Fields
      private readonly IRepository<PrivacyPolicy, PrivacyPolicySearch> _repo;
      #endregion

      #region PrivacyPolicyIndex Methods
      /// <summary>
      /// Executes when browser issues a Get request for /PrivacyPolicy and 
      /// directs to the Index view
      /// </summary>
      /// <returns>An ActionResult that contains an instance of PrivacyPolicyViewModel</returns>
      public ActionResult PrivacyPolicyIndex()
      {
        // Create view model and pass in repository
        PrivacyPolicyViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);
        
        // Restore Search Data
        vm.RestoreSearchFromJson();

        // Call method to load data
        vm.Search();

        return View(vm);
      }

      /// <summary>
      /// Handles the browser Post request for PrivacyPolicy form
      /// </summary>
      /// <param name="vm">A PrivacyPolicyViewModel instance for the entry</param>
      /// <returns>An ActionResult that either navigates to the index or stays on this view and displays errors</returns>
      [HttpPost]
      public ActionResult PrivacyPolicyIndex(PrivacyPolicyViewModel vm)
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
          return RedirectToAction("PrivacyPolicyIndex");
        }
        else {
          vm.IsDetailVisible = true;

          return View(vm);
        }
      }
      #endregion
   
      #region Search Method
      [HttpGet]
      public IActionResult Search(PrivacyPolicyViewModel vm)
      {
        // Assign Repository to View Model
        vm.Repository = _repo;

        // Initialize View Model
        Init(vm);
        
        // Reset Pager
        vm.ResetPagerProperties();

        // Call method to search for data
        vm.Search();

        return View("PrivacyPolicyIndex", vm);
      }
      #endregion
   
      #region SortPage Method
      [HttpGet]
      public IActionResult SortPage(PrivacyPolicyViewModel vm)
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

        return View("PrivacyPolicyIndex", vm);
      }
      #endregion

      #region Add Method
      [HttpGet]
      public IActionResult Add()
      {
        // Create view model and pass in repository
        PrivacyPolicyViewModel vm = new(_repo)
        {
          IsDetailVisible = true
        };

        // Initialize View Model
        Init(vm);

        // Call method to create an empty entity to add
        vm.CreateEmptyEntity();
        
        return View("PrivacyPolicyIndex", vm);
      }
      #endregion
   
      #region Edit Method
      [HttpGet]
      public IActionResult Edit(int id)
      {
        // Create view model and pass in repository
        PrivacyPolicyViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to load a single record
        vm.Get(id);
        
        return View("PrivacyPolicyIndex", vm);
      }
      #endregion
   
      #region Delete Method
      [HttpGet]
      public IActionResult Delete(int id)
      {
        // Create view model and pass in repository
        PrivacyPolicyViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to delete a record
        vm.Delete(id);

        return RedirectToAction("PrivacyPolicyIndex");
      }
      #endregion
   }
}
