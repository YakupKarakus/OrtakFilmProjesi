using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Controllers
{
    public class MainController : Controller
    {
        private readonly FilmRepository filmRepository;
        public MainController(FilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }
        public IActionResult Index()
        {
            var films = filmRepository.GetAll();
            return View(films);
        }
    }
}
