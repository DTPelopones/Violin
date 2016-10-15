
using System.Web.Mvc;


namespace AlexandraViolin.Controllers
{
    
    
    public class PortfolioController : BaseController
    {
        
        public ActionResult OneColumn()
        {
            return View();
        }
        
        public ActionResult SingleItem()
        {
            return View();
        }

        public ActionResult ThreeColumn()
        {
            ViewBag.controller = "Portfolio";
            ViewBag.action = "ThreeColumn";
            return View();
        }
    }
}
