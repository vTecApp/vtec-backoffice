using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace VerticalTec.Backoffice.Services
{
    public static class LanguageConfiguration
    {
        public static void ConfigSupportedLanguage(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var localization = services.BuildServiceProvider().GetService<Localization>();
                var supportedCultures = localization.Languages.Select(l => l.LangCode).ToArray();
                options.SetDefaultCulture(supportedCultures[0])
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });
        }
    }
}
