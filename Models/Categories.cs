using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Categories
    {
        public decimal Id { get; set; }
        public int IdLanguage { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public string Href { get; set; }

        public Languages IdLanguageNavigation { get; set; }
    }
}
