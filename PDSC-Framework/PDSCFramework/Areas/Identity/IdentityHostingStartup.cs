using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PDSCFramework.Areas.Identity.IdentityHostingStartup))]
namespace PDSCFramework.Areas.Identity
{
  public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}