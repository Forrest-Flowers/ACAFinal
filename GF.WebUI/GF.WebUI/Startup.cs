﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GF.Domain;
using GF.Data.Interfaces;
using GF.Data.Implementation.EFCore;
using GF.Service.Services;
using GF.Domain.Models;
using GF.Data.Context;
using Microsoft.AspNetCore.Identity;

namespace GF.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Repository Layer
            GetDependencyResolvedForEFCoreRepositoryLayer(services);

            //Service Layer
            GetDependencyResolvedForServiceLayer(services);

            services.AddDbContext<GFDbContext>();
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<GFDbContext>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Signin"; //overrides the default naming convention (Originally /Account/Login)
                options.AccessDeniedPath = "/Account/Unauthorized";
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 1;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        private void GetDependencyResolvedForServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, EFCoreUserRepository>();
            services.AddScoped<IGroupRepository, EFCoreGroupRepository>();
            services.AddScoped<IGroupUserLinkRepository, EFCoreGroupUserLinkRepository>();
            services.AddScoped<IEventRepository, EFCoreEventRepository>();
            services.AddScoped<IJoinRequestRepository, EFCoreJoinRequestRepository>();
            services.AddScoped<IJoinRequestStatusRepository, EFCoreJoinRequestStatusRepository>();
        }

        private void GetDependencyResolvedForEFCoreRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IGroupUserLinkService, GroupUserLinkService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IJoinRequestService, JoinRequestService>();
            services.AddScoped<IJoinRequestStatusService, JoinRequestStatusService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
     
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
