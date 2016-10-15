using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class ForumController : BaseController
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
