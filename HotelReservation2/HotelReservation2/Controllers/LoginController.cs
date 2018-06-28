using HotelReservation2.Models;
using HotelReservation2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HotelReservation2.Controllers
{
    public class LoginController : Controller
    {
        HotelDbContext db = new HotelDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login L)
        {
            User a = db.Users.FirstOrDefault(X => X.Email == L.Email && X.Password == L.Password);
            if (a != null) {
                FormsAuthentication.SetAuthCookie(L.Email, L.RememberMe);
                return RedirectToAction("Index", "Home", null);
                
            }
            ModelState.AddModelError("", "The User Name or Password is Invalied");
            return View();
        }
    }
}