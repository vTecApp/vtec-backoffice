using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerticalTec.Backoffice.Models;

namespace VerticalTec.Backoffice.Services
{
    public class LocalizationService
    {
        private Localization _localization;

        public LocalizationService(Localization locale)
        {
            _localization = locale;
        }

        public Locale[] Locales => _localization.Locales;

        public Locale Locale => _localization.Locales.Where(l => l.Selected).FirstOrDefault();

        public void SetSelectedLocale(string langCode)
        {
            var local = _localization.Locales.Where(l => l.LangCode == langCode).FirstOrDefault();
            if(local != null)
            {
                Locale.Selected = false;
                local.Selected = true;
            }
        }
    }
}
