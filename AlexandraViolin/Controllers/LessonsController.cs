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
            try
            {
                if (ModelState.IsValid)
                {
                    if (Request.IsAjaxRequest())
                    {
                        MailMessage mail = new MailMessage();
                        model.To = "dv.taranov@gmail.com";
                        model.Subject = "Письмо от " + model.FromName + " <" + model.FromEmail + "> с сайта aleksandrafedotova.ru";
                        mail.To.Add(model.To);
                        mail.To.Add("fedotova.violin@gmail.com");
                        mail.From = new MailAddress(model.FromEmail, model.FromName);
                        mail.Subject = model.Subject;
                        mail.Body = model.Body;

                        using (SmtpClient smtp = new SmtpClient())
                        {
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = new System.Net.NetworkCredential
                            ("dv.taranov@gmail.com", "");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                        model.FeedbackMessage = "Сообщение отправлено.";
                    }
                }
            }
            catch (Exception)
            {
                model.FeedbackMessage = "Сообщение не отправлено. Пожалуйста, повторите отправку!";
            }
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