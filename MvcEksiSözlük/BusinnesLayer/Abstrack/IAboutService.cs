using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstrack
{
    public interface IAboutService
    {
        List<About> GetList();
        void AboutAdd(About about);
        About GetById(int id);
        void Delete(About about);
        void Update(About about);
    }
}
