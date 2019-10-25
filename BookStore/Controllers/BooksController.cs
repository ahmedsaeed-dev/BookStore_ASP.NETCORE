﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Learning ASP.NET Core 2.0",
                Genre = "Programming & Software Development",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors = new List<string> { "Jason De Oliveria", "Michel Bruchet" }
            };
            return View(book);
        }
    }
}