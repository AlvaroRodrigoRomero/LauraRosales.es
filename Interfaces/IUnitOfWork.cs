using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriesRepository Categories { get; }
        IHomeRepository Home { get; }
        IAboutRepository About { get; }
        IExperiencesRepository Experiences { get; }
        ISocialNetworksRepository SocialNetworks { get; }
        int Complete();
    }
}
