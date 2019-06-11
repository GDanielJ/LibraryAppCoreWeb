using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppCoreWeb.Controllers
{
    public class AuthorsController : Controller
    {
        private ApplicationDbContext _context;

        // TODO - Seeda databasen med författare

        public AuthorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var authors = _context.Authors.ToList();

            return View(authors);
        }
    }
}