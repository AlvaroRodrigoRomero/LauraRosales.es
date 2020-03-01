using LadaWeb.Models;
using LadaWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadaWeb.Data
{
    public class CoreConverter
    {
        private readonly UnitOfWork _unitOfWork;

        public CoreConverter(LauraWebContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public HomeModel GetHomeModel()
        {
            var homeModel = new HomeModel();

            //homeModel.Categories  = _unitOfWork.Categories.GetAll().Where(x => x.NameNavigation.TextValues.Where(y => y.IdLanguage == 1))

            return homeModel;
        }
    }
}
