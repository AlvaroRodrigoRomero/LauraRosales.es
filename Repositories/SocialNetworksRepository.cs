using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class SocialNetworksRepository : Repository<SocialNetworks>, ISocialNetworksRepository
    {
        public SocialNetworksRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext LauraWebContext
        {
            get { return Context as LauraWebContext; }
        }
        
    }
}
