using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesAut1.Database;
using AccesAut1.Models;
using AccesAut1.Repositories;
using AccesAut1.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AccesAut1
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


            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });
            services.AddControllersWithViews();
            services.AddRazorPages();



            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.HttpOnly = true;
            //    options.LoginPath = "/Identity/Account/Login";
            //    options.AccessDeniedPath = "/Identity/Account/AccesDenied";
            //    options.SlidingExpiration = true;

            //});
            //services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddScoped<IAuthenticationServicee, AuthenticationServicee>();
            //services.AddIdentity<User, IdentityRole>()
            //.AddEntityFrameworkStores<Acsr3Context>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));

            services.AddIdentity<User, IdentityRole>()
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<Acsr3Context>();
            // services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
            //.AddRoles<IdentityRole>()
            //.AddEntityFrameworkStores<Acsr1Context>();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=AccesAuto30;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<Acsr3Context>
                    (options => options.UseSqlServer(connection));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
         
        
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
     
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(null, "MvcDashboardIdentity", "MvcDashboardIdentity/{controller=Home}/{action=Index}/{id?}");
               endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
