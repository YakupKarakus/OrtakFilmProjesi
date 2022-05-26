using Microsoft.AspNetCore.Mvc;
using OrtakFilmProjesi.Models;
using OrtakFilmProjesi.Models.Repositories.Abstract;
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
