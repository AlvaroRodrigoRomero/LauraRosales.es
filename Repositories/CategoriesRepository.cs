using LadaWeb.Interfaces;
using LadaWeb.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext LauraWebContext
        {
            get { return Context as LauraWebContext; }
        }

        public IEnumerable<Categories> GetCategoriesByLanguage(int idLanguage)
        {
            return LauraWebContext.Categories.Where(x => x.IdLanguage == idLanguage);
        }
    }
}
