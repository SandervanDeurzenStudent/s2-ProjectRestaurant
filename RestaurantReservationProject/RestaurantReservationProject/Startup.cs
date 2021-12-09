using System;
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
using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAcces.interfaces.interfaces;
using BusinessLogic.Restraurants;
using BusinessLogic.Models;
using Repositories.interfaces;
using Repositories;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Controller.Comments;
using Repositories.interfaces.dtos;
using BusinessLogic.Functions;

namespace RestaurantReservationProject
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<Test>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Test")));

            services.AddSingleton<IRestaurantContainerDal, RestaurantDal>();
            services.AddSingleton<IRestaurantDal, RestaurantDal>();
           
            services.AddSingleton<IRestaurantContainerLogic, RestaurantContainer>();
            services.AddSingleton<IRestaurantLogic, Restaurant>();

            //repositories
            services.AddSingleton<IRestaurantMySqlContext, RestaurantMySqlContext>();

            //comments
            services.AddSingleton<ICommentContainerDal, CommentDal>();
            services.AddSingleton<ICommentContainerLogic, CommentContainer>();
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
