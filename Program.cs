
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
    
    namespace sourceCode
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup global exception handler (equivalent to Application_Error in Global.asax)
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception)args.ExceptionObject;
                // Handle application errors - similar to Application_Error
            };

                var builder = WebApplication.CreateBuilder(args);
                
                // Store configuration in static ConfigurationManager
                ConfigurationManager.Configuration = builder.Configuration;
                
                // Add services to the container (formerly ConfigureServices)
                builder.Services.AddControllersWithViews();

                // Add configuration from web.config appSettings
                builder.Services.AddControllersWithViews(options => {
                    // ClientValidationEnabled was true in web.config
                    options.EnableEndpointRouting = true;
                });

                // Configure MVC options to match web.config settings
                builder.Services.AddMvc().AddMvcOptions(options =>
                {
                    // Area registration happens automatically in ASP.NET Core
                })
                .AddViewOptions(options => {
                    options.HtmlHelperOptions.ClientValidationEnabled = true;
                });
                //Added Services
                
                var app = builder.Build();
                
                // Configure the HTTP request pipeline (formerly Configure method)
                if (app.Environment.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler("/Home/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }
                
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                
                //Added Middleware
                
                app.UseRouting();

                app.UseAuthorization();

                // Support for namespaces that were in web.config <pages><namespaces>
                app.UseEndpoints(endpoints => {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                });

                // Configure routes
                app.UseEndpoints(endpoints =>
                {
                    // Original route from RouteConfig
                    endpoints.MapControllerRoute(
                        name: "Default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );

                    // Ignore routes (equivalent to routes.IgnoreRoute in the original)
                    endpoints.MapControllerRoute(
                        name: "IgnoreRoute",
                        pattern: "{resource}.axd/{*pathInfo}",
                        defaults: new { controller = "Empty", action = "Index" }
                    );

                    endpoints.MapControllers();
                });
                
                app.Run();
            }
        }
        
        public class ConfigurationManager
        {
            public static IConfiguration Configuration { get; set; }
        }
    }