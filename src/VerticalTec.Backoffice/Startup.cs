using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IdentityModel.Tokens.Jwt;
using VerticalTec.Backoffice.Models;
using VerticalTec.Backoffice.Services;

namespace VerticalTec.Backoffice
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
            services
                .AddControllersWithViews()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = 
                        (type, factory) => factory.Create(typeof(SharedResource));
                });

            JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
            .AddCookie("Cookies")
            .AddOpenIdConnect("oidc", options =>
            {
                options.Authority = "https://localhost:6001";

                options.ClientId = "vtec-backoffice";
                options.ClientSecret = "3df55b7b9570492c";
                options.ResponseType = "code";

                options.Scope.Add("profile");
                options.GetClaimsFromUserInfoEndpoint = true;

                options.SaveTokens = true;

                options.Scope.Add("vtec-api");
                options.Scope.Add("offline_access");
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.ConfigSupportedLanguage();
            services.AddRequestLocalization(options =>
            {
                options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider());
            });
        }

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

            app.UseRequestLocalization();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}")
                    .RequireAuthorization();
            });
        }
    }
}
