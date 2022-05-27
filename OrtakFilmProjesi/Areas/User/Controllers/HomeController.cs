using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Areas.User.Models;
using OrtakFilmProjesi.Models;
using OrtakFilmProjesi.Models.Repositories.Abstract;
using OrtakFilmProjesi.Models.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<OrtakFilmProjesi.Models.User> userRepository;
        private readonly IRepository<Film> filmRepository;

        public HomeController(IRepository<OrtakFilmProjesi.Models.User> userRepository, IRepository<Film> filmRepository)
        {
            this.userRepository = userRepository;
            this.filmRepository = filmRepository;
        }

        public IActionResult UserIndex()
        {
            IEnumerable<Film> films = filmRepository.GetAll();
            return View(films);
        }

        public IActionResult Detail(int id)
        {
            FilmVM filmVM = new FilmVM();
            Film film = filmVM.Film;
            filmVM.Film = filmRepository.GetById(id);

            return View(filmVM);
        }

        public IActionResult Buy(int id)
        {
            FilmVM filmVM = new FilmVM();
            Film film = filmVM.Film;
            filmVM.Film = filmRepository.GetById(id);

            return View(filmVM);
        }
    }
}
