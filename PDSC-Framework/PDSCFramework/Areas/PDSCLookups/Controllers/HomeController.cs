using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDSCFramework.Common;

namespace PDSC.Common.Controllers
{
  [Area("PDSCLookups")]
  [Authorize(Roles = "Administrator")]
  public class HomeController : AppControllerBase
  {
    #region Constructor
    public HomeController(AppSettings settings, ILogger<HomeController> logger) : base(settings)
    {
      Logger = logger;
    }
    #endregion

    #region Index Method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Index()
    {
      return View();
    }
    #endregion
  }
}
