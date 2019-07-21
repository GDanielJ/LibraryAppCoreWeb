using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Models;
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
            var books = _context.Books.Include(a => a.Author).ToList();

            return View(books);
        }

        [HttpGet]
        public IActionResult New()
        {
            var authors = _context.Authors.ToList();
            var viewModel = new BookFormViewModel()
            {
                Authors = authors
            };

            return View("BookForm", viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);

            if (bookInDb == null)
            {
                return NotFound();
            }

            IEnumerable<Author> authors = _context.Authors.ToList();

            var viewModel = new BookFormViewModel(bookInDb)
            {
                Authors = authors,
                Author = authors.SingleOrDefault(a => a.Id == bookInDb.AuthorId),
                AuthorId = bookInDb.AuthorId
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        public IActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book);

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);

                bookInDb.Name = book.Name;
                bookInDb.ReleaseDate = book.ReleaseDate;
            };

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        [HttpPost] // Borde vara HttpDelete
        public IActionResult DeleteBook(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);

            if (bookInDb == null)
                return NotFound();

            _context.Remove(bookInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

    }
}