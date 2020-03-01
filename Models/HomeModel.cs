using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Models
{
    public class HomeModel
    {
        public About About { get; set; }

        public List<Categories> Categories { get; set; }

        public List<Experiences> Experiences { get; set; }

        public Home Home { get; set; }

        public List<SocialNetworks> SocialNetworks { get; set; }

    }
}
