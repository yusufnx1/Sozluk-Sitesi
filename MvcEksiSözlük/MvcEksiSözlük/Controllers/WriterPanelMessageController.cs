using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAcessesLayer.Concrete;
using DataAcessesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEksiSözlük.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager mm = new MessageManager(new EFMessageDal());
        MessageValidatior messagevalidator = new MessageValidatior();
        public ActionResult Inbox()
        {
            string p = (string)Session["WriterMail"];
            var messagevalue = mm.GetListInbox(p);
            return View(messagevalue);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            string p = (string)Session["WriterMail"];
            var messagevalue = mm.GetListSendbox(p);
            return View(messagevalue);
        }
        public ActionResult GetInboxMessageSDetails(int id)
        {
            var getvalues = mm.GetById(id);
            return View(getvalues);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var sendvalues = mm.GetById(id);
            return View(sendvalues);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult result = messagevalidator.Validate(p);
            if (result.IsValid)
            {
                p.SenderMail = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}