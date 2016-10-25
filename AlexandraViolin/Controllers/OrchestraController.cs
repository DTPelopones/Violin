﻿using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Violin.Domain;

namespace AlexandraViolin.Controllers
{
    public class OrchestraController : BaseController
    {
        int pageSize = 15;
        public ActionResult Index(int? page)
        {
            string album = "Orchestra";
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
                return PartialView("OrchestraPart", photoes);
            }
            return View(photoes);
        }
    }
}