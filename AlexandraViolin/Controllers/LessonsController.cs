using System;
using System.Web.Mvc;
using AlexandraViolin.Models;
using System.Net.Mail;
using System.Linq;
using Violin.Domain;
using System.Collections.Generic;

namespace AlexandraViolin.Controllers
{
    public class LessonsController : BaseController
    {
        int pageSize = 24;

        [HttpPost]
        public ActionResult Feedback(EmailModel model)
        {
            sendEmail(model); 
            return PartialView("ErrorPartEmail", model); 
        }

        public ActionResult Index(int? page)
        {
            string album = "Lesson";
            IEnumerable<Photo> photoes = null;
            if (!page.HasValue)
            {
                photoes = repository.Photo.Where(f => f.path.Contains(album)).OrderBy(f => f.ID).Take(pageSize);
            }
            else
            {
                int pageIndex = pageSize * page.Value;
                photoes = repository.Photo.Where(f => f.path.Contains(album)).OrderBy(f => f.ID).Skip(pageIndex).Take(pageSize);
            }

            ViewBag.sendingProgress = "display: none;";
            ViewBag.album = album;

            if (Request.IsAjaxRequest())
            {
                return PartialView("LessonPart", photoes);
            }
            return View(photoes);
        }
    }
}