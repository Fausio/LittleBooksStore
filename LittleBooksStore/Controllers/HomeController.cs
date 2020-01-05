﻿using System;
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
        IRepository<Order> _Orderrepo;

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

        [HttpGet]
        public IActionResult Details(int Id)
        {
            return View(_Bookrepo.Get(Id));
        }

        public IActionResult Order(int? Id)
        {
            if (Id!=0 && Id>0)
            {
                var OrderViewModel = new OrderViewModel()
                {
                    BookToOrder = _Bookrepo.Get((int)Id),
                    OrderDetails = new Order()
                    {
                        BookId = (int)Id
                    }
                };
                return View(OrderViewModel);
            }
            return View();
        }

        public HomeController(IRepository<Book> book, IRepository<Carousel> carousel, IRepository<Order> order)
        {
            _Bookrepo = book;
            _Caroucelrepo = carousel   ;
            _Orderrepo = order;
        }
    }
}