using System;
using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Clients.Services;
using WebStore.DomainNew.Entities;
using WebStore.Interfaces;
using WebStore.Interfaces.Services;
using WebStore.Services;
namespace WebStore
{
    public class Startup
    {
        /// <summary>
        /// Добавляем свойство для доступа к конфигурации
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Добавляем новый конструктор, принимающий интерфейс IConfiguration
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Добавляем сервисы, необходимые для mvc
            services.AddMvc();
            // Добавляем реализацию клиента
            services.AddTransient<IValueService, ValuesClient>();
            services.AddTransient<IEmployeesData, EmployeesClient>();
            //services.AddTransient<IProductData, ProductsClient>();
            services.AddTransient<IOrdersService, OrdersClient>();
            services.AddTransient<IUsersClient, UsersClient>();
            // Настройка Identity
            services.AddIdentity<User, IdentityRole>()
            .AddDefaultTokenProviders();
            services.AddTransient<IUserStore<User>, CustomUserStore>();
            services.AddTransient<IUserRoleStore<User>, CustomUserStore>();
            services.AddTransient<IUserClaimStore<User>, CustomUserStore>();
            services.AddTransient<IUserPasswordStore<User>, CustomUserStore>();
            services.AddTransient<IUserTwoFactorStore<User>, CustomUserStore>();
            services.AddTransient<IUserEmailStore<User>, CustomUserStore>();
            services.AddTransient<IUserPhoneNumberStore<User>,
            CustomUserStore>();
            services.AddTransient<IUserLoginStore<User>, CustomUserStore>();
            services.AddTransient<IUserLockoutStore<User>, CustomUserStore>();
            services.AddTransient<IRoleStore<IdentityRole>, RolesClient>();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequiredLength = 3;
                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan =
                TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;
                // User settings
                options.User.RequireUniqueEmail = true;
            });
            services.ConfigureApplicationCookie(options =>
            {
            // Cookie settings
            options.Cookie.HttpOnly = true;
            options.Cookie.Expiration = TimeSpan.FromDays(150);
// If the LoginPath is not set here, ASP.NET Core will default to/Account/Login
            options.LoginPath = "/Account/Login";
// If the LogoutPath is not set here, ASP.NET Core will default to/ Account / Logout
options.LogoutPath = "/Account/Logout";
// If the AccessDeniedPath is not set here, ASP.NET Core will default to/ Account / AccessDenied
options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            // Настройки для корзины
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICartService, CookieCartService>();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
        IServiceProvider svp,ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                                app.UseCors(builder =>
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());



            // Добавляем расширение для использования статических файлов, т.к. appsettings.json - это статический файл
            app.UseStaticFiles();
            app.UseWelcomePage("/welcome");
            app.UseAuthentication();
            // Добавляем обработку запросов в mvc-формате
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "areas",
                template: "{area:exists}/{controller=Home}/{action=Index}");
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}