using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAcessesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace MvcEksiSözlük.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());

        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidatior rules = new CategoryValidatior();
            ValidationResult validation = rules.Validate(p);
            if (validation.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var categoryvalues = cm.GetById(id);
            cm.Delete(categoryvalues);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var categoryvalues = cm.GetById(id);
            return View(categoryvalues);
        }
        [HttpPost]
        public ActionResult Update(Category p)
        {
            cm.Update(p);
            return RedirectToAction("Index");
        }
    }
}