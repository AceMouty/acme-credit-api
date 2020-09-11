using System;
using AcmeApi.Data;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            // Using a policy that has the API completely open for development purposes
            // in deployment be sure to crate a access list of URL's / Clients that can talk
            // to the API

            services.AddCors( opt => {
                opt.AddPolicy(CorsPolicy, builder => {
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });
            
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
            
            
            // Commented out so project will work on Local host
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
