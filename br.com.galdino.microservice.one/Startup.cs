using System.Collections.Generic;
using AutoMapper;
using br.com.galdino.microservice.one.api.Configurations.Injection;
using br.com.galdino.microservice.one.api.Filters.Performace;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace br.com.galdino.microservice.one
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServices();
            services.AddControllers();

            services.AddMvc(options =>
            {
                options.Filters.AddService<PerformaceFilters>();
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Microservice for value metrics", Version = "v1" });
                
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "br.com.galdino.microservice.one v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(builder => 
                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
                
                );
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });
        }
    }
}
