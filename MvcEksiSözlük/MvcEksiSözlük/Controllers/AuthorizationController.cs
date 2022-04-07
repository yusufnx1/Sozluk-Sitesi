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
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager Am = new AdminManager(new EFAdminDal());
        public ActionResult Index()
        {
            var adminvalues = Am.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            Am.AdminAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdmin(int id)
        {
            var adminvalues = Am.GetById(id);
            Am.Delete(adminvalues);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminUpdate(int id)
        {
            var adminvalues = Am.GetById(id);
            return View(adminvalues);
        }
        [HttpPost]
        public ActionResult AdminUpdate(Admin p)
        {
            Am.Update(p);
            return RedirectToAction("Index");
        }
    }
}