using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppCoreWeb.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                // Tillfällig hårdkodning
                new Book
                {
                    Id = 1,
                    Name = "The Fellowship of the Ring",
                    ReleaseDate = new DateTime(1954, 07, 29, 12, 00, 0)
                },
                new Book
                {
                    Id = 2,
                    Name = "A Game of Thrones",
                    ReleaseDate = new DateTime(1996, 08, 01, 12, 00, 0)
                },
                new Book
                {
                    Id = 3,
                    Name = "The Hunger Games",
                    ReleaseDate = new DateTime(2008, 09, 14, 12, 00, 0)
                }
            };

            return View(books);
        }
    }
}