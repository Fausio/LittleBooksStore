using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LittleBooksStore.Models;
using LittleBooksStore.Services;

namespace LittleBooksStore.Controllers
{
    public class HomeController : Controller
    {
          IRepository<Book> _repo; 

        //the  home page
        public IActionResult Index()
        {
              return View(_repo.GetAll());
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


        public HomeController()
        {
            _repo = new MockBooksRepository();
        }
    }
}