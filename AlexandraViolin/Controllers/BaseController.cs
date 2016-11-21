using System;
using System.Net.Mail;
using AlexandraViolin.Models;
using System.Web.Mvc;
using Violin.Domain;
using Ninject; 

namespace AlexandraViolin.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public IRepository repository { get; set; }

        public bool sendEmail(EmailModel model)
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
                            smtp.Credentials = new System.Net.NetworkCredential("dv.taranov@gmail.com", ""); 
                            smtp.EnableSsl = true; 
                            smtp.Send(mail); 
                        } 
                        model.FeedbackMessage = "Сообщение отправлено."; 
                        return true; 
                    }
                }
            }
            catch (Exception)
            {
                model.FeedbackMessage = "Сообщение не отправлено. Пожалуйста, повторите отправку!";    
            }
            return false;
        }
    }
}