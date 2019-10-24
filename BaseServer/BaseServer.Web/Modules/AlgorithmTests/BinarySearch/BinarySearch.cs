
namespace BaseServer.AlgorithmTests.BinarySearch.Pages
{
    using BaseServer.Common;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("AlgorithmTests/BinarySearch"), Route("{action=index}")]
    public class BinarySearchController : Controller
    {
        [HttpGet,Route("AlgorithmTests/BinarySearch")]
        public ActionResult Index()
        {
            
            return View(MVC.Views.AlgorithmTests.BinarySearch.BinarySearchIndex, new DashboardPageModel());
        }
    }
}
