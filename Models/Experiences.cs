using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Experiences
    {
        public int Id { get; set; }
        public int IdLanguage { get; set; }
        public string Title { get; set; }
        public string Restaurant { get; set; }
        public string Text { get; set; }
        public string Year { get; set; }
        public bool Active { get; set; }

        public Languages IdLanguageNavigation { get; set; }
    }
}
