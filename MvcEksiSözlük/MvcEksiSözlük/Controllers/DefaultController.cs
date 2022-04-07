using BusinnesLayer.Concrete;
using DataAcessesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEksiSözlük.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        ContentManager cm = new ContentManager(new EFContentDal());
        public ActionResult Headings()
        {
            var headinglist = hm.HeadingGetList();
            return View(headinglist);
        }

        public PartialViewResult Index(int id=1)
        {
            var contentslist = cm.GetListByHeadingId(id);
            return PartialView(contentslist);
        }
    }
}