using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PDSCFramework.Common
{
  /// <summary>
  /// This filter is used to set any ViewData items for each page
  /// </summary>
  public class AppViewDataFilter : IActionFilter
  {
    public AppViewDataFilter(AppSession session)
    {
      UserSession = session;
    }

    protected AppSession UserSession { get; set; }

    public void OnActionExecuting(ActionExecutingContext context)
    {
      if (UserSession != null) {
        if (context.Controller is Controller controller) {
          controller.ViewData["CustomerName"] = UserSession.CustomerName;
        }
      }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
      if (UserSession != null) {
        if (context.Controller is Controller controller) {
          // Do something here after action has been executed    
        }
      }
    }
  }
}
