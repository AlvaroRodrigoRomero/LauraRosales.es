using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class TextValues
    {
        public long Id { get; set; }
        public int IdLanguage { get; set; }
        public long Type { get; set; }
        public string Text { get; set; }

        public Languages IdLanguageNavigation { get; set; }
        public Texts TypeNavigation { get; set; }
    }
}
