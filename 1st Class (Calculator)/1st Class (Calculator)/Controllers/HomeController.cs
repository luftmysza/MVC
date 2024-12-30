using _1st_Class__Calculator_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _1st_Class__Calculator_.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            Dane[] osoby =
            {
                new Dane{Imie="Jan", Nazwisko="Kowalski"},
                new Dane{Imie="Anna", Nazwisko="Nowak"},
                new Dane{Imie="Monika", Nazwisko="Zabłotnik"}
            };
            ViewBag.Name = "Jan";
            ViewBag.godzina = DateTime.Now.Hour;
            ViewBag.powitanie =
                ViewBag.godzina < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }

        public IActionResult Urodziny()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UrodzinyForm(Urodziny urodziny)
        {
            ViewBag.Message = $"Witaj {urodziny.Imie} {urodziny.Nazwisko}, masz {DateTime.Now.Year - urodziny.Rok} lat";
            return View();
        }
        public IActionResult Kalkulator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KalkulatorWynik(Kalkulator kalkulator)
        {
            int wynik = 0;
            if (kalkulator.znak == "dod") wynik = kalkulator.liczba1 + kalkulator.liczba2;
            else if (kalkulator.znak == "ode") wynik = kalkulator.liczba1 - kalkulator.liczba2;
            ViewBag.Wynik = wynik;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
