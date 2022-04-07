using BusinnesLayer.Abstrack;
using DataAcessesLayer.Abstrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class AboutManager : IAboutService
    {

        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _aboutDal.Insert(about);
        }

        public void Delete(About about)
        {
            _aboutDal.Delete(about);
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(x=>x.AboutID==id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
