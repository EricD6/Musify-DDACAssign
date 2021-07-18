using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Musify_DDAC_Assignment.Areas.Identity.Data;
using Musify_DDAC_Assignment.Data;

[assembly: HostingStartup(typeof(Musify_DDAC_Assignment.Areas.Identity.IdentityHostingStartup))]
namespace Musify_DDAC_Assignment.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Musify_DDAC_AssignmentContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Musify_DDAC_AssignmentContextConnection")));

                services.AddDefaultIdentity<Musify_DDAC_AssignmentUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Musify_DDAC_AssignmentContext>();
            });
        }
    }
}