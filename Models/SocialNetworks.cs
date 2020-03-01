using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class SocialNetworks
    {
        public decimal Id { get; set; }
        public decimal Type { get; set; }
        public string Src { get; set; }
        public bool Active { get; set; }
        public string Title { get; set; }
        public string Css { get; set; }
    }
}
