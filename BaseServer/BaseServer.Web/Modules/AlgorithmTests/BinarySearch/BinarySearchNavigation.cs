using Serenity.Navigation;
using MyPages = BaseServer.AlgorithmTests.BinarySearch.Pages;


[assembly: NavigationMenu(9000, "AlgorithmTests", icon: "fa-code")]
[assembly: NavigationLink(3, "AlgorithmTests/BinarySearch", typeof(MyPages.BinarySearchController), icon: "fa-search")]

