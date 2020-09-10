using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeApi.Data;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AcmeApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string CorsPolicy = "CorsPolicy";
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors( opt => {
                opt.AddPolicy(CorsPolicy, builder => {
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                    // .WithOrigins(new string[] {"http://localhost:4200/loans"});
                });
            });

            // services.AddCors( opt => {
            //     opt.AddDefaultPolicy( builder => builder.WithOrigins(new string[] {"http://localhost:4200"}).AllowAnyMethod().AllowAnyHeader());
            // });
            
            services.AddControllers();

            // Get access to SqlServer
            services.AddDbContext<LoanContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("AcmeConnection")));

            // Create a service for our Loan repo so that it can be injected where it needs to be used.
            services.AddScoped<ILoanRepo, SqlLoanRepo>();

            // Automapper service, makes Automapper available to the rest of the application via dependency injection.
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            
            // app.UseHttpsRedirection();

            app.UseCors(CorsPolicy);

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
