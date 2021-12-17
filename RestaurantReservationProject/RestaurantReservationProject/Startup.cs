
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAcces.interfaces.interfaces;
using BusinessLogic.Restraurants;
using BusinessLogic.Interfaces.Comments;
using BusinessLogic.Controller.Comments;
using BusinessLogic.Functions;
using Presentation.RestaurantConverter;
using Presentation.Converter;
using BusinessLogic;
using BusinessLogic.Converter;
using BusinessLogic.Interfaces.Reservations;
using BusinessLogic.Containers;
using DataAccess.interfaces.interfaces.Reservations;
using DataAccess.MySqlContext;
using DataAccess.interfaces.Repositories;
using DataAccess.Repository;
using DataAcces.interfaces.Repositories;

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

            //restaurant Converters view 
            services.AddTransient<RestaurantViewConverter>();
            
            //restaurant converters Logic
            services.AddTransient<RestaurantLogicConverter>();

            //restaurant logic
            services.AddTransient<IRestaurantContainerLogic, RestaurantContainer>();
            services.AddTransient<IRestaurantLogic, Restaurant>();

            //restaurant dal
            services.AddTransient<IRestaurantContainerContext, RestaurantMySqlContext>();
            services.AddTransient<IRestaurantContext, RestaurantMySqlContext>();

            //restaurant dal interfaces
            services.AddTransient<IRestaurantContainerRepository, RestaurantRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();

            //COMMENTS

            //comments converter view
            services.AddTransient<RestaurantViewConverter>();
            //comments coverter View
            services.AddTransient<CommentViewConverter>();
            //comments converter Logic
            services.AddTransient<CommentLogicConverter>();

            //commentsLogic
            services.AddTransient<ICommentContainerLogic, CommentContainer>();

            //comments Dal
            services.AddTransient<ICommentContainerContext, CommentMySqlContext>();


            //RESERVATION
            //comments coverter View
            services.AddTransient<ReservationViewConverter>();
            //comments converter Logic
            services.AddTransient<ReservationLogicConverter>();


            //commentsLogic
            services.AddTransient<IReservationContainer, ReservationContainer>();

            //comments Dal
            services.AddTransient<IReservationContainerContext, ReservationMySqlContext>();
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
