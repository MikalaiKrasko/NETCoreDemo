using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Ogorodik.Web.Areas.Identity.IdentityHostingStartup))]
namespace Ogorodik.Web.Areas.Identity
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