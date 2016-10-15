using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class AboutController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.controller = "About";
            ViewBag.action = "Index";
            return View();
        }
	}
}