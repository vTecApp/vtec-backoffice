using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace VerticalTec.Backoffice.Services
{
    public static class LanguageConfiguration
    {
        public static void ConfigSupportedLanguage(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[] { "en-US", "th" };
                options.SetDefaultCulture(supportedCultures[0])
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });
        }
    }
}
