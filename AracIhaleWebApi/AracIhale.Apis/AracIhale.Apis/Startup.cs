using AracIhale.Apis.Models;
using AracIhale.Apis.Models.DAL.Concrete;
using AracIhale.Apis.Models.DAL.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale.Apis
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
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IKullaniciDAL, EfKullaniciRepoBaseDAL>();
            services.AddScoped<IIhaleStatuDAL, EfIhaleStatuRepoBaseDAL>();
            services.AddScoped<ISirketDAL, EfSirketRepoBaseDAL>();
            services.AddScoped<IRolDAL, EfRolRepoBaseDAL>();
            services.AddScoped<IAracDAL, EfAracRepoBaseDAL>();
            services.AddScoped<IIhaleDAL, EfIhaleRepoBaseDAL>();
            services.AddScoped<IAracIhaleDAL, EfAracIhaleRepoBaseDAL>();
            services.AddScoped<IIhaleFiyatDAL, EfIhaleFiyatEkleRepoBaseDAL>();
            services.AddScoped<IIhaleFiyatBelirlemeDAL, EfIhaleFiyatBelirlemeRepoBaseDAL>();
            services.AddScoped<IIhaleyeAracEkleDAL, EfIhaleyeAracEkleRepoBaseDAL>();
            services.AddDbContext<MyContext>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
