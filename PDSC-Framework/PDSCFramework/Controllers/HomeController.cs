using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDSC.Common;
using PDSC.Common.EntityLayer;
using PDSC.Common.ViewModelLayer;
using PDSCFramework.Common;
using PDSCFramework.Common.ViewModelLayer;

namespace PDSCFramework.Controllers
{
  public class HomeController : AppControllerBase
  {
    #region Constructor
    public HomeController(AppSettings settings,
      ILogger<HomeController> logger,
      IRepository<ContactUs, ContactUsSearch> contactUsRepo,
      IRepository<FAQ, FAQSearch> faqRepo,
      IRepository<PrivacyPolicy, PrivacyPolicySearch> privacyRepo,
      IRepository<SiteTerms, SiteTermsSearch> termsRepo) : base(settings, logger)
    {
      _ContactUsRepository = contactUsRepo;
      _FAQRepository = faqRepo;
      _PrivacyPolicyRepository = privacyRepo;
      _TermsRepository = termsRepo;
    }
    #endregion

    #region Properties/Fields
    private readonly IRepository<ContactUs, ContactUsSearch> _ContactUsRepository;
    private readonly IRepository<FAQ, FAQSearch> _FAQRepository;
    private readonly IRepository<PrivacyPolicy, PrivacyPolicySearch> _PrivacyPolicyRepository;
    private readonly IRepository<SiteTerms, SiteTermsSearch> _TermsRepository;
    #endregion

    #region Index Method
    public IActionResult Index()
    {
      IndexViewModel vm = new()
      {
        AppSettings = AppSettings
      };

      // Initialize View Model
      Init(vm);

      // Log entry for home page
      Logger.LogInformation("{0}, {1}, {2}", "Home Page", base.GetRemoteIPAddress(), AppSettings.EmailAliases.Support);

      return View(vm);
    }
    #endregion

    #region ContactUs Method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult ContactUs()
    {
      PDSC.Common.ViewModelLayer.ContactUsViewModel vm = new(_ContactUsRepository)
      {
        AppSettings = AppSettings,
        Mode = "single"
      };

      // Initialize View Model
      Init(vm);

      // Set IP Address
      vm.SelectedEntity.IPAddress = base.GetRemoteIPAddress();
      // Set InsertName/UpdateName to IP Address
      vm.SelectedEntity.InsertName = vm.SelectedEntity.IPAddress;
      vm.SelectedEntity.UpdateName = vm.SelectedEntity.IPAddress;

      // Create empty entity for adding a new contact us
      vm.CreateEmptyEntity();

      return View(vm);
    }

    [HttpPost]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult ContactUs(PDSC.Common.ViewModelLayer.ContactUsViewModel vm)
    {
      IActionResult ret = View(vm);

      if (ModelState.IsValid) {
        // Set Repository object
        vm.Repository = _ContactUsRepository;
        vm.AppSettings = AppSettings;

        // Initialize View Model
        Init(vm);

        // Save Contact Us Request
        if(vm.Save()) {
          // TODO: Setup email sender for Contact Us Page
          // vm.EmailHelper = _EmailSender;
          vm.SendEmail();
        }

        if (vm.IsSaved || vm.IsDuplicate) {
          ret = RedirectToAction("ContactUsThankYou");
        }
        else {
          ModelState.Clear();
          foreach (var item in vm.Messages) {
            ModelState.AddModelError(item, item);
          }
        }
      }

      return ret;
    }
    #endregion

    #region ContactUsThankYou Method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult ContactUsThankYou()
    {
      return View();
    }
    #endregion

    #region FAQ Method
    public IActionResult FAQ()
    {
      PDSC.Common.ViewModelLayer.FAQViewModel vm = new(_FAQRepository)
      {
        AppSettings = AppSettings
      };

      // Initialize View Model
      Init(vm);

      vm.Search();

      return View(vm);
    }
    #endregion

    #region Privacy Method
    public IActionResult Privacy()
    {
      PrivacyPolicyViewModel vm = new(_PrivacyPolicyRepository)
      {
        AppSettings = AppSettings
      };

      // Initialize View Model
      Init(vm);

      // Retrieve current privacy policy
      vm.GetLatest();

      return View(vm);
    }
    #endregion

    #region TermsOfService Method
    public IActionResult TermsOfService()
    {
      PDSC.Common.ViewModelLayer.SiteTermsViewModel vm = new(_TermsRepository)
      {
        AppSettings = AppSettings
      };

      // Initialize View Model
      Init(vm);

      vm.GetLatest();

      return View(vm);
    }
    #endregion

    #region Unsubscribe Methods
    public IActionResult Unsubscribe()
    {
      PDSC.Common.ViewModelLayer.UnsubscribeViewModel vm = new()
      {
        AppSettings = AppSettings
      };

      // Initialize View Model
      Init(vm);

      return View(vm);
    }

    [HttpPost]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Unsubscribe(PDSC.Common.ViewModelLayer.UnsubscribeViewModel vm)
    {
      IActionResult ret = View(vm);

      // Set AppSetting object
      vm.AppSettings = AppSettings;

      if (ModelState.IsValid) {
        // Initialize View Model
        Init(vm);

        // Unsubscribe the user
        vm.Unsubscribe();

        if (vm.IsValid) {
          ret = RedirectToAction("UnsubscribeThankYou");
        }
        else {
          ModelState.Clear();
          foreach (var item in vm.Messages) {
            ModelState.AddModelError(item, item);
          }
        }
      }

      return ret;
    }
    #endregion

    #region UnsubscribeThankYou Method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult UnsubscribeThankYou()
    {
      return View();
    }
    #endregion

  }
}
