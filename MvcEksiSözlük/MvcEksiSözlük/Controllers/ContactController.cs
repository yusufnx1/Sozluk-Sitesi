using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAcessesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEksiSözlük.Controllers
{
    public class ContactController : Controller
    {
        ContanctManager cm = new ContanctManager(new EFContactDal());
        ContactValidator cv = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contantvalues = cm.GetList();
            return View(contantvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}