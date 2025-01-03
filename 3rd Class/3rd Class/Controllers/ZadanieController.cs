using _3rd_Class.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3rd_Class.Controllers
{
    public class ZadanieController : Controller
    {
        // GET: ZadanieController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormZadanie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormZadanie(Zadanie dane)
        {
            if (ModelState.IsValid) return View("WynikZadanie", dane);
            else return View();
        }

        public IActionResult WynikZadanie(Zadanie dane)
        {
            return View(dane);
        }

        // GET: ZadanieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZadanieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZadanieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZadanieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZadanieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZadanieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZadanieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
