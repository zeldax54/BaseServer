
namespace BaseServer.Visitors.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Visitors/Visitors"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VisitorsRow))]
    public class VisitorsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Visitors/Visitors/VisitorsIndex.cshtml");
        }
    }
}