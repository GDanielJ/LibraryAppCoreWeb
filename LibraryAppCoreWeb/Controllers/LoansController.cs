using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Models;
using LibraryAppCoreWeb.ViewModels;
using LibraryAppCoreWeb.Data;

namespace LibraryAppCoreWeb.Controllers
{
    public class LoansController : Controller
    {
        private ApplicationDbContext _context;

        public LoansController(ApplicationDbContext Context)
        {
            _context = Context;
        }

        public IActionResult New()
        {
            var books = _context.Books.ToList();
            var viewModel = new LoanFormViewModel()
            {
                Books = books
            };

            return View("LoanForm", viewModel);
        }

        //public IActionResult SaveNewLoan()
        //{

        //}
    }
}