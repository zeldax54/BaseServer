
namespace BaseServer.FrontPage.Pages
{
    using BaseServer.Common;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("Front"), Route("{action=index}")]
    public class FrontPageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(MVC.Views.FrontPage.FrontPage_, new DashboardPageModel());
        }
    }
}
