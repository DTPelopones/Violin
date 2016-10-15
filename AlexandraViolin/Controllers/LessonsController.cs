using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class LessonsController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.controller = "Lessons";
            ViewBag.action = "Index";
            return View();
        }
	}
}