using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {
        // localhost:5000/home/index
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat>12?"İyi Günler":"Günaydın";
            ViewBag.UserName = "Barış";

            return View();
        }

        // localhost:5000/home/about
        public IActionResult About(){
            return View();
        }

        public IActionResult Contact(){
            return View("MyView");
        }
    }
}