using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class AboutRepository : Repository<About>, IAboutRepository
    {
        public AboutRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext LauraWebContext
        {
            get { return Context as LauraWebContext; }
        }

        public About GetAboutByLanguage(int idLanguage)
        {
            return LauraWebContext.About.Where(x => x.IdLanguage == idLanguage).FirstOrDefault();
        }
    }
}
