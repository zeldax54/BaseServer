using Serenity.Navigation;
using MyPages = BaseServer.Data.Pages;

[assembly: NavigationMenu(9000, "Data", icon: "fa-book")]
[assembly: NavigationLink(int.MaxValue, "Data/Temperature Data", typeof(MyPages.TemperatureDataController), icon: "fa-home")]
[assembly: NavigationLink(int.MaxValue, "Data/DataDash", typeof(MyPages.DataDashController), icon: "fa-bar-chart-o")]