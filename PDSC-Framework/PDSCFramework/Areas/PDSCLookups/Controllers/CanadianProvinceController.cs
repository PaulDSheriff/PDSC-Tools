using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PDSC.Common.EntityLayer;
using PDSC.Common.ViewModelLayer;
using PDSCFramework.Common;

namespace PDSC.Common.Controllers
{
  [Area("PDSCLookups")]
  [Authorize(Roles = "Administrator")]
  public partial class CanadianProvinceController : AppControllerBase
   {
      #region Constructor
      /// <summary>
      /// Constructor for CanadianProvinceController class
      /// </summary>
      public CanadianProvinceController(AppSession session,
        AppSettings settings,
        IRepositoryStringPK<CanadianProvince, CanadianProvinceSearch> repo) : base(session, settings)
      {
        _repo = repo;
      }
      #endregion

      #region Private Fields
      private readonly IRepositoryStringPK<CanadianProvince, CanadianProvinceSearch> _repo;
      #endregion

      #region CanadianProvinceIndex Methods
      /// <summary>
      /// Executes when browser issues a Get request for /CanadianProvince and 
      /// directs to the Index view
      /// </summary>
      /// <returns>An ActionResult that contains an instance of CanadianProvinceViewModel</returns>
      public ActionResult CanadianProvinceIndex()
      {
        // Create view model and pass in repository
        CanadianProvinceViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);
        
        // Restore Search Data
        vm.RestoreSearchFromJson();

        // Call method to load data
        vm.Search();

        return View(vm);
      }

      /// <summary>
      /// Handles the browser Post request for CanadianProvince form
      /// </summary>
      /// <param name="vm">A CanadianProvinceViewModel instance for the entry</param>
      /// <returns>An ActionResult that either navigates to the index or stays on this view and displays errors</returns>
      [HttpPost]
      public ActionResult CanadianProvinceIndex(CanadianProvinceViewModel vm)
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
          return RedirectToAction("CanadianProvinceIndex");
        }
        else {
          vm.IsDetailVisible = true;

          return View(vm);
        }
      }
      #endregion
   
      #region Search Method
      [HttpGet]
      public IActionResult Search(CanadianProvinceViewModel vm)
      {
        // Assign Repository to View Model
        vm.Repository = _repo;

        // Initialize View Model
        Init(vm);
        
        // Reset Pager
        vm.ResetPagerProperties();

        // Call method to search for data
        vm.Search();

        return View("CanadianProvinceIndex", vm);
      }
      #endregion
   
      #region SortPage Method
      [HttpGet]
      public IActionResult SortPage(CanadianProvinceViewModel vm)
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

        return View("CanadianProvinceIndex", vm);
      }
      #endregion

      #region Add Method
      [HttpGet]
      public IActionResult Add()
      {
        // Create view model and pass in repository
        CanadianProvinceViewModel vm = new(_repo)
        {
          IsDetailVisible = true
        };

        // Initialize View Model
        Init(vm);

        // Call method to create an empty entity to add
        vm.CreateEmptyEntity();
        
        return View("CanadianProvinceIndex", vm);
      }
      #endregion
   
      #region Edit Method
      [HttpGet]
      public IActionResult Edit(string id)
      {
        // Create view model and pass in repository
        CanadianProvinceViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to load a single record
        vm.Get(id);
        
        return View("CanadianProvinceIndex", vm);
      }
      #endregion
   
      #region Delete Method
      [HttpGet]
      public IActionResult Delete(string id)
      {
        // Create view model and pass in repository
        CanadianProvinceViewModel vm = new(_repo);

        // Initialize View Model
        Init(vm);

        // Call method to delete a record
        vm.Delete(id);

        return RedirectToAction("CanadianProvinceIndex");
      }
      #endregion
   }
}
