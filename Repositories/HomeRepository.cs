using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class HomeRepository : Repository<Home>, IHomeRepository
    {
        public HomeRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext LauraWebContext
        {
            get { return Context as LauraWebContext; }
        }

        public Home GetHomeByLanguage(int idLanguage)
        {
            return LauraWebContext.Home.Where(x => x.IdLanguage == idLanguage).FirstOrDefault();
        }
    }
}
