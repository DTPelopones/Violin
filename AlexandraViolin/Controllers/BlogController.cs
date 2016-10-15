using System.Web.Mvc;


namespace AlexandraViolin.Controllers
{
    
    
    public class BlogController : BaseController
    {
        
        public ActionResult Home1()
        {
            ViewBag.controller = "Blog";
            ViewBag.action = "Home1";
            return View();
        }

        public ActionResult Home2()
        {
            ViewBag.controller = "Blog";
            ViewBag.action = "Home2";
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }
    }
}
