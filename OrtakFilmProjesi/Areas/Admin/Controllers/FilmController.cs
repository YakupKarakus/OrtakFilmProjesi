using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models;
using OrtakFilmProjesi.Models.Repositories.Concrete;

namespace OrtakFilmProjesi.Areas.Admin.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmRepository filmRepository;

        public FilmController(FilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }
        // GET: FilmController
        public ActionResult Index()
        {
            return View(filmRepository.GetAll());
        }

        // GET: FilmController/Details/5
        

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    filmRepository.Add(film);
                    return RedirectToAction("Index");
                }
                return View(film);
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmController/Edit/5
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

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            var film = filmRepository.GetById(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            try
            {
                var article = filmRepository.GetById(id);
                filmRepository.Delete(article);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
