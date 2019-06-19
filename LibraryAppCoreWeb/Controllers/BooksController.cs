using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Data;
using LibraryAppCoreWeb.ViewModels;

namespace LibraryAppCoreWeb.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _context.Books.ToList();

            return View(books);
        }

        public IActionResult New() //TODO - forts här. Skapa ny form BookForm
        {
            var authors = _context.Authors.ToList();
            var viewModel = new BookFormViewModel()
            {
                Authors = authors
            };

            return View();
        }

        public IActionResult Edit(int id)
        {
            var books = _context.Books.SingleOrDefault(b => b.Id == id);

            return View(books);
        }

        public IActionResult Save(Book book)
        {

        }

    }
}