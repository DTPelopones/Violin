using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Violin.Domain;
using Ninject; 

namespace AlexandraViolin.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public IRepository repository { get; set; }
    }
}