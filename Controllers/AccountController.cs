using Microsoft.AspNetCore.Mvc;
using Products.NetCore.Models;

namespace Products.NetCore.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (user.Username == "admin" && user.Password == "12345")
            {
                // Başarılı giriş işlemi
                return RedirectToAction("Index", "Products");
            }

            // Hatalı giriş işlemi
            ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya parola";
            return View();
        }
    }
    
}





   
