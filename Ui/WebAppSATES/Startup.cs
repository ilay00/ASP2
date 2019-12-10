using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using WebAppSATES.Clients.Services;
using WebAppSATES.DAL.Context;
using WebAppSATES.Data;

using WebAppSATES.Domain.Entities.Identity;
using WebAppSATES.Infrastructure;
using WebAppSATES.Infrastructure.Interfaces;
using WebAppSATES.Infrastructure.Services;
using WebAppSATES.Interfaces;
using WebAppSATES.Services.InMemory;

namespace WebAppSATES
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration Config) => Configuration = Config;

        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddDbContext<WebAppSATESContext>(opt => 
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<Data>();
            services.AddTransient<IValuseServices, ValuesClient>();
            services.AddSingleton<IEmployeesData, InMemoryEmployeesData>();
            services.AddScoped<IProductData, SqlProductData>();
            services.AddScoped<IProductData, InMemoryProductData>();
            services.AddScoped<ICartService, CookieCartService>();

            services.AddIdentity<User, Role>()
               .AddEntityFrameworkStores<WebAppSATESContext>()
               .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(
                opt =>
                {
                    opt.Password.RequiredLength = 3;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredUniqueChars = 3;

                    opt.Lockout.AllowedForNewUsers = true;
                    opt.Lockout.MaxFailedAccessAttempts = 10;
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);

                    //opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABC123";
                    opt.User.RequireUniqueEmail = false; // Грабли - на этапе отладки при попытке регистрации двух пользователей без email
                });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "WebAppSATES-Identity";
                opt.Cookie.HttpOnly = true;
                opt.Cookie.Expiration = TimeSpan.FromDays(150);

                opt.LoginPath = "/Account/Login";
                opt.LogoutPath = "/Account/Logout";
                opt.AccessDeniedPath = "/Account/AccessDenided";

                opt.SlidingExpiration = true;
            });

            services.AddSession();

            services.AddMvc(options =>
            {
                //options.Filters.Add(typeof(SimpleActionFilter));
                options.Filters.Add(new SimpleActionFilter());
            });
        }

        public void Configure(WebAppSATESContextInitializer db, IApplicationBuilder app, IHostingEnvironment env)
        {
            db.InitializeAsync().Wait();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }


            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseSession();

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
