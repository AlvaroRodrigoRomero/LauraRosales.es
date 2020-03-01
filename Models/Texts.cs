using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Texts
    {
        public Texts()
        {
            TextValues = new HashSet<TextValues>();
        }

        public long Id { get; set; }
        public string Text { get; set; }

        public ICollection<TextValues> TextValues { get; set; }
    }
}
