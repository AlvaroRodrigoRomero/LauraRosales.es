using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Home
    {
        public decimal Id { get; set; }
        public int IdLanguage { get; set; }
        public string ImageBackgroundSrc { get; set; }
        public string ImageLogoSrc { get; set; }
        public string H1 { get; set; }
        public string H2 { get; set; }
        public string TypedStrings { get; set; }

        public Languages IdLanguageNavigation { get; set; }
    }
}
