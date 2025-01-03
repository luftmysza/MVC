using _4th_Class__Entity_Framework_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Diagnostics;

namespace _4th_Class__Entity_Framework_.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmDbContext _context;
        public FilmController(FilmDbContext context)
        {
            _context = context;
        }

        // GET: FilmController
        public async Task<ActionResult> Index()
        {
            List<Film> films = await _context.Films.Include(f => f.Category).ToListAsync();

            return View(films);
        }

        // GET: FilmController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Film? film = await _context.Films.Include(f => f.Category).FirstOrDefaultAsync(x => x.ID == id);

            return View(film);
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(new Film());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {
                film.Category = _context.Categories.Find(film.CategoryId);
                _context.Films.Add(film);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                List<Category> categories = _context.Categories.ToList();
                ViewBag.Categories = new SelectList(categories, "Id", "Name");
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            Film? film = await _context.Films.Include(f => f.Category).FirstOrDefaultAsync(x => x.ID == id);

            return View(film);
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Film film)
        {
            try
            {
                _context.Films.Update(film);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            Film? film = await _context.Films.Include(f => f.Category).FirstOrDefaultAsync(x => x.ID == id);

            return View(film);
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(Film film)
        {
            try
            {
                _context.Films.Remove(film);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}