using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LittleBooksStore.Models;
using LittleBooksStore.Services;
using LittleBooksStore.ViewModels;

namespace LittleBooksStore.Controllers
{
    public class HomeController : Controller
    {
          IRepository<Book> _Bookrepo;
          IRepository<Carousel> _Caroucelrepo;

        //the  home page
        public IActionResult Index()
        {
            var viewmodel = new HomeIndexViewModel()
            {
                Books = _Bookrepo.GetAll(),
                Carousels = _Caroucelrepo.GetAll()
            };

              return View(viewmodel);
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


        //the  Add Book
        public IActionResult AddBook()
        {
            return View();
        }

        public HomeController()
        {
            _Bookrepo = new MockBooksRepository();
            _Caroucelrepo = new MockCarouselRepository();
        }
    }
}