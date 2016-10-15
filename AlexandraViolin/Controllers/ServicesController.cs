using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class ServicesController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.controller = "Services";
            ViewBag.action = "Index";
            return View();
        }
	}
}