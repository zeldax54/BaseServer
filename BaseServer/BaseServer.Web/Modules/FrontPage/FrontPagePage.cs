
namespace BaseServer.FrontPage.Pages
{
    using BaseServer.Common;
    using RestSharp;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;
    using Hepers;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using BaseServer.FrontPage.Model;

    [RoutePrefix("Front"), Route("{action=index}")]
    public class FrontPageController : Controller
    {
        [HttpGet,Route("~/")]
        public ActionResult Index()
        {
            string ip = Request.UserHostAddress;
            if(ip== "::1")
             ip = "181.229.0.54";
            var clientip = new RestClient($"http://ip-api.com/json/{ip}");
            var requestip = new RestRequest(Method.GET);
            IRestResponse responseip = clientip.Execute(requestip);       
            Hepers.IpResponse ipResponse = JsonConvert.DeserializeObject<Hepers.IpResponse>(responseip.Content);
            //SaveData           
            //Mudar a thread
            var connection=SqlConnections.NewByKey("Default");
            connection.Query($"Insert into Visitors (Ip,Coords,City,Country) values('{ip}','{ipResponse.lat + ":" + ipResponse.lon}','{ipResponse.city}','{ipResponse.country}')");
            //Wheather
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={ipResponse.city},{ipResponse.countryCode}&APPID=2e1487498cb7f439f5dad79bbc59033a&mode=json&units=metric";
            //var urllat = "http://api.openweathermap.org/data/2.5/weather?lat={ipResponse.lat}&lon={ipResponse.lon}&APPID=2e1487498cb7f439f5dad79bbc59033a&mode=json&units=metric";
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Hepers.WheatherResponse wheatherResponse = JsonConvert.DeserializeObject<Hepers.WheatherResponse>(response.Content);
            wheatherResponse.weather[0].icon = $"http://openweathermap.org/img/wn/{wheatherResponse.weather[0].icon}.png";
            FrontPageModel model = new FrontPageModel()
            {
                IpResponse = ipResponse,
                WheatherResponse = wheatherResponse

            };            
            return View(MVC.Views.FrontPage.FrontPage_, model);
        }
    }
}
