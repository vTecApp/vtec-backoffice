using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalTec.Backoffice.Services
{
    public class CustomRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            var localeService = httpContext.RequestServices.GetService<Localization>();
            var requestCulture = httpContext.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];

            var culture = requestCulture.Split("|")[0].Split("=").Last();
            var uiCulture = requestCulture.Split("|")[1].Split("=").Last();

            if (culture == "id")
            {
                localeService.QtyFormat = "#,##0";
                localeService.CurrencyFormat = "#,##0";
            }
            else
            {
                localeService.QtyFormat = "#,##0";
                localeService.CurrencyFormat = "#,##0.00";
            }

            var providerResultCulture = new ProviderCultureResult(culture, uiCulture);
            return Task.FromResult(providerResultCulture);
        }
    }
}
