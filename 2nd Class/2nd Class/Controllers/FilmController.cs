using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2nd_Class.Models;

namespace _2nd_Class.Controllers
{
    public class FilmController : Controller
    {
        private static readonly List<Film> _films = new List<Film>
        {
            new Film() {ID = 1, Name = "Godzilla", Description = "Description1", Price = 4 },
            new Film() {ID = 2, Name = "King Kong", Description = "Description2", Price = 5 },
            new Film() {ID = 3, Name = "Godzilla vs. Kong", Description = "Description3", Price = 6 }
        };

        // GET: FilmController
        public ActionResult Index()
        {
            return View(_films);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(_films.FirstOrDefault(x => x.ID == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View(new Film());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {
                film.ID = _films.Count + 1;
                _films.Add(film);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_films.FirstOrDefault(x => x.ID == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Film film)
        {
            try
            {
                _films[film.ID] = film;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_films.FirstOrDefault(x => x.ID == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(Film film)
        {
            try
            {
                _films.Remove(_films.FirstOrDefault(x => x.ID == film.ID));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
