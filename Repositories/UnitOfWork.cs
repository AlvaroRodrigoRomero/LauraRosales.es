using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LauraWebContext _context;

        public UnitOfWork(LauraWebContext context)
        {
            _context = context;
            Users = new UsersRepository(context);
            Categories = new CategoriesRepository(context);
            Home = new HomeRepository(context);
            About = new AboutRepository(context);
            Experiences = new ExperiencesRepository(context);
            SocialNetworks = new SocialNetworksRepository(context);
        }
        
        public IUsersRepository Users { get; private set; }
        public ICategoriesRepository Categories { get; private set; }
        public IHomeRepository Home { get; private set; }
        public IAboutRepository About { get; private set; }
        public IExperiencesRepository Experiences { get; private set; }
        public ISocialNetworksRepository SocialNetworks { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
