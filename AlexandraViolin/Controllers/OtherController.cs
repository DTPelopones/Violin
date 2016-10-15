
using System.Web.Mvc;


namespace AlexandraViolin.Controllers
{
    
    
    public class OtherController : BaseController
    {
        
        public ActionResult FullWidth()
        {
            return View();
        }
        
        public ActionResult SideBar()
        {
            return View();
        }
        
        public ActionResult Faq()
        {
            ViewBag.controller = "Other";
            ViewBag.action = "Faq";
            return View();
        }
        
        public ActionResult FourOhFour()
        {
            return View();
        }
    }
}
