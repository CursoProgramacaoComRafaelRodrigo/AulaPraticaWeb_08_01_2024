using AulaPraticaWeb_08_01_2024.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace AulaPraticaWeb_08_01_2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.data = $"Bem vindo {DateTime.Now.Year}";
            ViewBag.res = Divi2Numeros(100,5);
            return View();
        }

        public IActionResult Pessoa()
        {
            Pessoa p = new Pessoa();
            return View(p);
        }
        public IActionResult Listas()
        {
            ViewBag.ok = Multiplica2Numeros(30, 8).ToString("N2",CultureInfo.CurrentCulture);
            return View();
        }
        public IActionResult While_Enquanto()
        {
            return View();
        }
        public IActionResult For_Para()
        {
            return View();
        }
        public IActionResult Foreatch_Usnado()
        {
            Soma2Numeros();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        private int Divi2Numeros(int n1,int n2)
        {
            return n1 / n2;
        } 
        private decimal Multiplica2Numeros(decimal n1,decimal n2)
        {
            return n1 * n2;
        }

        public void Soma2Numeros()
        {
            int n1 = 20;
            int n2 = 30;
            int soma = n1 + n2;
            ViewBag.e = soma;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
