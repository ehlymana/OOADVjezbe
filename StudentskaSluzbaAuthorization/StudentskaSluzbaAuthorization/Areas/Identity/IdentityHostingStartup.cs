using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentskaSluzbaAuthorization.Data;

[assembly: HostingStartup(typeof(StudentskaSluzbaAuthorization.Areas.Identity.IdentityHostingStartup))]
namespace StudentskaSluzbaAuthorization.Areas.Identity
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