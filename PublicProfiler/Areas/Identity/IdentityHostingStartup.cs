using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PublicProfiler.Areas.Identity.Data;
using PublicProfiler.Data;

[assembly: HostingStartup(typeof(PublicProfiler.Areas.Identity.IdentityHostingStartup))]
namespace PublicProfiler.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PublicProfilerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PublicProfilerContextConnection")));

                services.AddDefaultIdentity<PublicProfilerUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PublicProfilerContext>();
            });
        }
    }
}