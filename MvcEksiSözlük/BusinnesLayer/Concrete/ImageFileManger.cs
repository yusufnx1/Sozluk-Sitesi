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
    public class ImageFileManger : IImageFileService
    {
        IImageFileDal _imageDal;

        public ImageFileManger(IImageFileDal imageDal)
        {
            _imageDal = imageDal;
        }

        public List<ImageFile> GetList()
        {
           return _imageDal.List();
        }
    }
}
