using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.Common.ModelMappers;
using CoffeeBlog.Common.Models;
using CoffeeBlog.Common.Repository;
using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Services.BlogService;
using CoffeeBlog.WebApi.Services.ImageService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddMvc(m => {
                m.EnableEndpointRouting = false; 
            });
            services.AddOptions();
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton(Configuration);

            //MS SQL
            services.AddEntityFrameworkSqlServer().AddDbContext<CbDbContext>();

            services.AddScoped<IEntityMapper, CoffeeBlogEntityMapper>();

            services.AddScoped<IRepository<Article>, ArticleJsonRepository>();
            services.AddScoped<IBusinessService<ArticleDataTransferModel>, BlogBusinessService>();
            services.AddScoped<IBusinessService<ImageDataTransferModel>, ImageBusinessService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(options => options.AllowAnyOrigin());
        }
    }
}
