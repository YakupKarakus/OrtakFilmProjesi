using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models.Repositories.Concrete;


namespace OrtakFilmProjesi.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        
        private readonly UserRepository _userRepository;

        public AdminController(UserRepository userRepository) 
        {
            
            this._userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }



        

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(OrtakFilmProjesi.Models.User user)
        {
            var _user = _userRepository.GetByMailAndPassword(user.Mail,user.Password);
            if (_user == null)
            {
                TempData["Message"] = "Giriş bilgileri hatalı.";
                return View();
            }
            HttpContext.Session.SetString("Mail", user.Mail);
            HttpContext.Session.SetString("Password", user.Password);
            TempData["Message"] = "Hoşgeldin";
            return RedirectToAction("Index", "Home");
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Mail");
            HttpContext.Session.Remove("Password");
            TempData["Message"] = "Güle güle";
            return RedirectToAction("Index", "Home");
        }



    }
}
