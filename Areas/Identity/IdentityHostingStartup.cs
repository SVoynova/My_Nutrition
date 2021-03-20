using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(My_Nutrition.Areas.Identity.IdentityHostingStartup))]
namespace My_Nutrition.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}