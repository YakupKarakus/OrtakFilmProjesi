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
        private readonly IRepository<Film> filmRepository;
        public MainController(IRepository<Film> filmRepository)
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
