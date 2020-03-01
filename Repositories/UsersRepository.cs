using LadaWeb.Interfaces;
using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Repositories
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(LauraWebContext context) : base(context) { }

        public LauraWebContext lauraWebContext
        {
            get { return Context as LauraWebContext; }
        }
    }
}
