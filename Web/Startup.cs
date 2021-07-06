using Application.Interfaces;
using Application.Service;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
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

            services.AddControllers();

            services.AddScoped<ICurrencyConverter, CurrencyConverter>();
            services.AddScoped<IMainCalculatorService, AnnuitiesService>();
            services.AddScoped<IMainCalculatorService, CashServices>();
            services.AddScoped<IMainCalculatorService, ExchangeTradedService>();
            services.AddScoped<IMainCalculatorService, FixedInterestService>();
            services.AddScoped<IMainCalculatorService, InvestmentBondService>();
            services.AddScoped<IMainCalculatorService, ListedInvestmentService>();
            services.AddScoped<IMainCalculatorService, ManagedFundService>();
            services.AddScoped<IMainCalculatorService, RealEstateService>();
            services.AddScoped<IMainCalculatorService, RealEstateService>();

            services.AddCors(options =>
            {
                options.AddPolicy("NotesPolicy",
                    builder =>
                    {
                        builder.WithOrigins("*")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
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
            app.UseCors("NotesPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
