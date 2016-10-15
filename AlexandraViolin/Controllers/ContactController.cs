using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class ContactController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.controller = "Contact";
            ViewBag.action = "Index";
            return View();
        }
	}
}