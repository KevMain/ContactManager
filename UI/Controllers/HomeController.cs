using System;
using System.Web.Mvc;
using Castle.Core.Logging;

namespace CompatibleSoftware.ContactManager.UI.Controllers
{
    public class HomeController : Controller
    {
        public ILogger Logger { get; set; }

        public ActionResult Index()
        {
            throw new Exception("failed");

            return View();
        }
    }
}
