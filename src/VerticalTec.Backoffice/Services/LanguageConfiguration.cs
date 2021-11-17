using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using VerticalTec.Backoffice.Models;

namespace VerticalTec.Backoffice.Services
{
    public static class LanguageConfiguration
    {
        public static void ConfigSupportedLanguage(this IServiceCollection services)
        {
            services.AddScoped<Localization>();
            services.AddScoped<LocalizationService>();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var localization = services.BuildServiceProvider().GetService<LocalizationService>();
                var supportedCultures = localization.Locales.Select(l => l.LangCode).ToArray();
                options.SetDefaultCulture(supportedCultures[0])
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });
        }
    }
}
