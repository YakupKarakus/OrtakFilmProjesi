using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models;
using OrtakFilmProjesi.Models.Repositories.Abstract;
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
        private readonly IRepository<Film> filmler;
        public MainController(IRepository<Film> filmler)
        {
            this.filmler = filmler;
        }
        public IActionResult Index()
        {
            var films = filmler.GetAll();
            return View(films);
        }
    }
}
