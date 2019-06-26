
namespace BaseServer.Data.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Data/TemperatureData"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TemperatureDataRow))]
    public class TemperatureDataController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Data/TemperatureData/TemperatureDataIndex.cshtml");
        }
    }
}