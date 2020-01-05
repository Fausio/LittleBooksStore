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


        [HttpGet]
        //the  Add Book
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book )
        {
            if (ModelState.IsValid)
            {
                Book Item = new Book()
                {
                    Id = _Bookrepo.GetAll().Max(book => book.Id) + 1,
                    Author = book.Author,
                    Description = book.Description,
                    image = book.image,
                    Price = book.Price,
                    PublishDate = book.PublishDate,
                    Title = book.Title
                };

                _Bookrepo.Add(Item);
                 return View();
            }
            return View();
        }

        public HomeController(IRepository<Book> book, IRepository<Carousel> carousel)
        {
            _Bookrepo = book;
            _Caroucelrepo = carousel   ;
        }
    }
}