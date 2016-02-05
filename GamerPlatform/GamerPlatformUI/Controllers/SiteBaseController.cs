using Data.Context;
using Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Business.Repository; 

namespace GamerPlatformUI.Controllers
{
    public class SiteBaseController : Controller
    {
        protected YorGameContext db;
        Repository<Category> rep = new Repository<Category>();
        public SiteBaseController()
        {
            db = new YorGameContext();
        }
        public PartialViewResult GetBilgisayar()
        {
            List<Category> catList = rep.FindBy(x => x.ParentID == 6).ToList();
            List<Category> catList2 = rep.FindBy(x => x.ParentID == 12).ToList();
            Category cat = rep.FindByID(6);
            ViewBag.cat = cat.Name;
            ViewData["childList"] = catList2;
            return PartialView("~/Views/SiteShared/SitePartials/BilgisayarPartial.cshtml", catList);
        }
        public PartialViewResult GetCategory()
        {
            List<Category> catList = rep.FindBy(x => x.ParentID == 6).ToList();
            Category cat = rep.FindByID(6);
            ViewBag.cat = cat.Name;
            return PartialView("~/Views/SiteShared/SitePartials/CategoryPartial.cshtml", catList);
        }

    }
}