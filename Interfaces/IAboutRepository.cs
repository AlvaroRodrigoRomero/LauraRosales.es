﻿using LadaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Interfaces
{
    public interface IAboutRepository : IRepository<About>
    {
        About GetAboutByLanguage(int idLanguage);
    }
}
