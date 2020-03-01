using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class About
    {
        public decimal Id { get; set; }
        public int IdLanguage { get; set; }
        public string ImageProfileSrc { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birth { get; set; }
        public string Location { get; set; }
        public string Nacionality { get; set; }
        public string Text { get; set; }

        public Languages IdLanguageNavigation { get; set; }
    }
}
