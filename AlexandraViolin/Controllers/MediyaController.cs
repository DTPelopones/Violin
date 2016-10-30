using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Violin.Domain;

namespace AlexandraViolin.Controllers
{
    public class MediyaController : BaseController
    {
        int pageSize = 16;
        public ActionResult Photo(int? page, string album)
        {
            IEnumerable<Photo> photoes = null;
            if(!page.HasValue)
            {
                photoes = repository.Photo.Where(f=>f.path.Contains(album)).Where(f=>f.sort!=null).OrderBy(f => f.sort).Take(pageSize);
            }
            else
            {
                int pageIndex = pageSize * page.Value;
                photoes = repository.Photo.Where(f => f.path.Contains(album)).Where(f => f.sort != null).OrderBy(f=>f.sort).Skip(pageIndex).Take(pageSize);
            }
            ViewBag.album = album;

            if (Request.IsAjaxRequest())
            {
                return PartialView("PhotoPart", photoes);
            }
            return View(photoes);
        }
        
        public ActionResult SingleItem()
        {
            return View();
        }

        public ActionResult Audio()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(); 
        }
    }
}
