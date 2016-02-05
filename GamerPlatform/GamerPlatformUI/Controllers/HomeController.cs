using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerPlatformUI.Controllers
{
    public class HomeController : SiteBaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}