using DataAcessesLayer.Abstrack;
using DataAcessesLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessesLayer.EntityFramework
{
    public class EFImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {
    }
}
