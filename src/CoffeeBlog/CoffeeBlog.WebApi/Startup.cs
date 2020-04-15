using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.ModelMappers;
using CoffeeBlog.WebApi.Services;
using CoffeeBlog.WebApi.Services.BlogService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoffeeBlog.WebApi
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
            services.AddOptions();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton(Configuration);

            //MS SQL
            services.AddEntityFrameworkSqlServer().AddDbContext<CbDbContext>();

            //SQLite
            services.AddScoped<IEntityMapper, CoffeeBlogEntityMapper>();
            services.AddScoped<IRepository, ArticleJsonRepository>();
            services.AddScoped<IBusinessService<BlogDataTransferModel>, BlogBusinessService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}