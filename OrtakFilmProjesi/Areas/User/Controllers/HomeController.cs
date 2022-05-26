using Microsoft.AspNetCore.Mvc;
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

        public HomeController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
