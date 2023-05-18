using AracIhale.UI.MyProvider;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
     .AddCookie();



            services.AddControllersWithViews();
            services.AddAuthorization();

          
            services.AddDistributedMemoryCache(); // Oturum verilerinin bellekte depolanmasý için daðýtýlmýþ bellek öbeði kullanýlacak
            services.AddHttpContextAccessor();
            services.AddSession(options =>
            {
                options.Cookie.Name = "MySession"; // Oturum çerezi adý
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Oturum süresi 20 dakika
                options.Cookie.HttpOnly = true; // Sadece HTTP istekleri aracýlýðýyla eriþilebilecek
                options.Cookie.IsEssential = true; // Gerekli olarak iþaretlenmiþ oturum çerezi
            });
            services.AddHttpClient<KullaniciApiProvider>(config =>
            {
                config.BaseAddress = new Uri(Configuration["apiBaseURL"]);
            });
            services.AddHttpClient<AracApiProvider>(config =>
            {
                config.BaseAddress = new Uri(Configuration["apiBaseURL"]);
            });
            services.AddHttpClient<IhaleApiProvider>(config =>
            {
                config.BaseAddress = new Uri(Configuration["apiBaseURL"]);
            });

          
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseSession();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Kullanici}/{action=Index}/{id?}");
            });
        }
    }
}
