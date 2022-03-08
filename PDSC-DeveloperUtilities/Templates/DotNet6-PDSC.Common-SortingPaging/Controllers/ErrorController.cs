using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PDSC.Common.ViewModelLayer;
using System.Diagnostics;

namespace PDSCFramework.Controllers {
  [AllowAnonymous]
  public class ErrorController : Controller
  {
    public IActionResult StatusCodeRedirect(int code)
    {
      ErrorViewModel vm = new()
      {
        // Set status code property
        StatusCode = code.ToString()
      };

      // Build page name from status code number
      return View("StatusCode" + vm.StatusCode.ToString(), vm);
    }

    public IActionResult StatusCodeReExecute(int code)
    {
      ErrorViewModel vm = new()
      {
        // Set status code property
        StatusCode = code.ToString()
      };

      // Get some path information
      var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
      if (feature != null) {
        vm.StatusPath =
            feature.OriginalPathBase
            + feature.OriginalPath
            + feature.OriginalQueryString;
      }

      // Build page name from status code number
      return View("StatusCode" + vm.StatusCode.ToString(), vm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult ErrorDevelopment([FromServices] IWebHostEnvironment hostEnv)
    {
      ErrorViewModel vm = new ();

      if (hostEnv.EnvironmentName != "Development") {
        throw new InvalidOperationException(
            "This shouldn't be invoked in non-development environments.");
      }

      var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
      if (context != null) {
        vm = new ErrorViewModel
        {
          RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
          StackTrace = context.Error.StackTrace,
          ErrorMessage = context.Error.Message,
          ErrorSource = context.Error.Source,
          ApplicationName = hostEnv.ApplicationName,
          ContentRootPath = hostEnv.ContentRootPath
        };
      }

      return View(vm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
