using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalTec.Backoffice.Services
{
    public class CustomRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            var localeService = httpContext.RequestServices.GetService<LocalizationService>();
            var requestCulture = httpContext.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];

            var culture = requestCulture?.Split("|")[0].Split("=").Last() ?? "en-US";
            var uiCulture = requestCulture?.Split("|")[1].Split("=").Last() ?? "en-US";

            localeService.SetSelectedLocale(uiCulture);

            var providerResultCulture = new ProviderCultureResult(culture, uiCulture);
            return Task.FromResult(providerResultCulture);
        }
    }
}
