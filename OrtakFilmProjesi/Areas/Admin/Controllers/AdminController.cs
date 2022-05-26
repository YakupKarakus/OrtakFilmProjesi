using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models;
using OrtakFilmProjesi.Models.Repositories.Abstract;
using OrtakFilmProjesi.Models.Repositories.Concrete;

namespace OrtakFilmProjesi.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly FilmRepository _filmRepository;
        private readonly UserRepository _userRepository;

        public AdminController(FilmRepository filmRepository, UserRepository userRepository) 
        {
            this._filmRepository = filmRepository;
            this._userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View(_filmRepository.GetAll());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                _filmRepository.Add(film);
                return RedirectToAction("Index");
            }
            return View(film);
            
        }
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = _filmRepository.GetById(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var article = _filmRepository.GetById(id);
            _filmRepository.Delete(article);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int id,string mail,string password)
        {
            if (ModelState.IsValid)
            {
                var user=_userRepository.GetById(id);
               if (user.Mail == mail && user.Password == password)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Login");
                }


            }
            return View();
        }

        

    }
}
