using Microsoft.AspNetCore.Mvc;
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
        private readonly UserRepository userRepository;
        private readonly FilmRepository filmRepository;

        public HomeController(UserRepository userRepository, FilmRepository filmRepository)
        {
            this.userRepository = userRepository;
            this.filmRepository = filmRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Film> films = filmRepository.GetAll();
            return View(films);
        }
    }
}
