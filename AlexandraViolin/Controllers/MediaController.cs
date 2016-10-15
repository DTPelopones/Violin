using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class MediaController : BaseController
    {
        public ActionResult OneColumn()
        {
            return View();
        }
        
        public ActionResult SingleItem()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(); 
        }
    }
}
