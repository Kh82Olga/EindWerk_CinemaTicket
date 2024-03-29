using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Data.Repositories;
using EindWerk_CinemaTicket.Data.ShopCart;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket
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
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IActor, ActorRepo>();
            services.AddScoped<IGenre, GenreRepo>();
            services.AddScoped<ICinemaHall, CinemaHallRepo>();
            services.AddScoped<IMovie, MovieRepo>();
            services.AddScoped<IOrder, OrderRepo>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sc => ShoppingCart.GetCart(sc));

            services.AddSession();
            

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddMemoryCache();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
                
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Movie}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();
        }
    }
}
