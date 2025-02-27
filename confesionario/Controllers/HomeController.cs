using CapaPrincipal.Service;
using confesionario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace confesionario.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;


        }



        public IActionResult Index()
        {
            var product = context.Products.OrderByDescending(p => p.Id).Take(8).ToList();

            return View(product);
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
