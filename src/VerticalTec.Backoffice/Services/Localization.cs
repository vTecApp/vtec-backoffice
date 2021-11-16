namespace VerticalTec.Backoffice.Services
{
    public class Localization
    {
        public Language[] Languages { get; set; } = new Language[]
        {
            new Language("en-US", "EN"),
            new Language("th", "TH"),
            new Language("id", "ID")
        };

        public string QtyFormat { get; set; } = "#,##0";
        public string CurrencyFormat { get; set; } = "#,##0.00";
        public string DateFormat { get; set; } = "dd/MM/yyyy";
        public string TimeFormat { get; set; } = "HH:mm:ss";
    }

    public class Language
    {
        public Language(string langCode, string langName)
        {
            LangCode = langCode;
            LangName = langName;
        }

        public string LangCode { get; set; }
        public string LangName { get; set; }
    }
}
