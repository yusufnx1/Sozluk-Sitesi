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
    public class HeadingManager : IHeadingService
    {

        IHeadingDal _headingdal;

        public HeadingManager(IHeadingDal headingdal)
        {
            _headingdal = headingdal;
        }

        public Heading GetById(int id)
        {
            return _headingdal.Get(x => x.HeaindgID == id);
        }

        public List<Heading> GetListByWriter(int id)
        {
            return _headingdal.List(x => x.WriterID == id);
        }

        public void HeadingAdd(Heading heading)
        {
            _headingdal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            // heading.HeadingStatus = false;- Yanlış kullanım.
            _headingdal.Update(heading);
        }

        public List<Heading> HeadingGetList()
        {
            return _headingdal.List();
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingdal.Update(heading);
        }
    }
}
