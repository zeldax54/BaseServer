﻿
namespace BaseServer.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("~/Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [HttpGet, Route("~/Dashboard")]
        public ActionResult Index()
        {
            return View(MVC.Views.Common.Dashboard.DashboardIndex, new DashboardPageModel());
        }
    }
}
