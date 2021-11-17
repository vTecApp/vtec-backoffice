namespace VerticalTec.Backoffice.Models
{
    public class Localization
    {
        public Locale[] Locales { get; set; } = new Locale[]
        {
            new Locale("en-US", "EN"){
                Selected = true
            },
            new Locale("th-TH", "TH"),
            new Locale("id-ID", "ID")
            {
                Format = new Format
                {
                    QtyFormat = "#,##0",
                    CurrencyFormat = "#,##0"
                }
            }
        };
    }

    public class Locale
    {
        public Locale(string langCode, string langName)
        {
            LangCode = langCode;
            LangName = langName;
        }

        public string LangCode { get; set; }
        public string LangName { get; set; }
        public bool Selected { get; set; }
        public Format Format { get; set; } = new Format();
    }

    public class Format
    {
        public string QtyFormat { get; set; } = "#,##0";
        public string CurrencyFormat { get; set; } = "#,##0.00";
        public string DateFormat { get; set; } = "dd/MM/yyyy";
        public string TimeFormat { get; set; } = "HH:mm:ss";
    }
}
