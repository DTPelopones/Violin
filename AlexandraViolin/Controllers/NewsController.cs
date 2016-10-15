using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class NewsController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }
    }
}