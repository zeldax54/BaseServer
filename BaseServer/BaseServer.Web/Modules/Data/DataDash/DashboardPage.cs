
namespace BaseServer.Data.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("DataDash"), Route("{action=index}")]
    public class DataDashController : Controller
    {
        [HttpGet, Route("~/DataDash")]
        public ActionResult Index()
        {
            return View(MVC.Views.Data.DataDash.DataDashIndex, null);
        }
    }
}
