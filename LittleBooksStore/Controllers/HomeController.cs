using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LittleBooksStore.Controllers
{
    public class HomeController : Controller
    {

        //the  home page
        public IActionResult Index()
        {
            return View();
        }


        // the  About page
        public IActionResult About()
        {
            return View();
        }

        //the  contact page
        public IActionResult Contact()
        {
            return View();
        }
    }
}