using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LittleBooksStore.Models;

namespace LittleBooksStore.Controllers
{
    public class HomeController : Controller
    {
        private List<Book> _book;

        //the  home page
        public IActionResult Index()
        {
              return View(_book);
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
            _book = new List<Book>();
            _book.Add(
                new Book()
                {
                    Id = 1,
                    Title = "The Witcher 3",
                    Description = "Geralt the Wolf of Rivia",
                    Author = "Fausio Matsinhe",
                    PublishDate = "July, 2018",
                    Price = 39.01,
                    image = ""
                });

            _book.Add(
                 new Book()
                 {
                     Id = 2,
                     Title = "The Hobbit",
                     Description = "Lord of the rings",
                     Author = "Carlos Uchia",
                     PublishDate = "Jan, 2020",
                     Price = 39.01,
                     image = ""
                 });
        }
    }
}