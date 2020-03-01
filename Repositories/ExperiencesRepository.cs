using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class ExperiencesRepository : Repository<Experiences>, IExperiencesRepository
    {
        public ExperiencesRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext LauraWebContext
        {
            get { return Context as LauraWebContext; }
        }

        public IEnumerable<Experiences> GetExperiencesByLanguage(int idLanguage)
        {
            return LauraWebContext.Experiences.Where(x => x.IdLanguage == idLanguage);
        }
    }
}
