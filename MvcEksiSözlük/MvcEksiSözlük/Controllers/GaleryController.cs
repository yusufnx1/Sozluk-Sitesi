using BusinnesLayer.Concrete;
using DataAcessesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEksiSözlük.Controllers
{
    public class GaleryController : Controller
    {
        ImageFileManger ifm = new ImageFileManger(new EFImageFileDal());
        // GET: Galery
        public ActionResult Index()
        {
            var imagevalue = ifm.GetList();
            return View(imagevalue);
        }
    }
}