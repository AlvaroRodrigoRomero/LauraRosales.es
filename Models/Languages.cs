using System;
using System.Collections.Generic;

namespace LadaWeb.Models
{
    public partial class Languages
    {
        public Languages()
        {
            About = new HashSet<About>();
            Categories = new HashSet<Categories>();
            Experiences = new HashSet<Experiences>();
            Home = new HashSet<Home>();
            TextValues = new HashSet<TextValues>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<About> About { get; set; }
        public ICollection<Categories> Categories { get; set; }
        public ICollection<Experiences> Experiences { get; set; }
        public ICollection<Home> Home { get; set; }
        public ICollection<TextValues> TextValues { get; set; }
    }
}
