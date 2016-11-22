using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Violin.Domain;
using System.Web.Mvc;

namespace AlexandraViolin.Controllers
{
    public class VideoController : BaseController
    {
        // GET: Video
        public ActionResult Index()
        {
            return View();
        }
    }
}