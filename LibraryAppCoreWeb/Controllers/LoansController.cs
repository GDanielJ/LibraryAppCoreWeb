using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Models;
using LibraryAppCoreWeb.ViewModels;
using LibraryAppCoreWeb.Data;
using LibraryAppCoreWeb.Dtos;

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
            var viewModel = new LoanFormViewModel();

            return View("LoanForm", viewModel);
        }

        public IActionResult SaveNewLoan(LoanDto loanDto)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new LoanFormViewModel
                {
                    Id = loanDto.Id,
                    MemberId = loanDto.MemberId,
                    BookId = loanDto.BookId,
                    CheckOutDate = loanDto.CheckOutDate,
                    DueDate = loanDto.DueDate
                };

                return View("LoanForm", viewModel);
            }

            if (loanDto.Id == 0)
            {
                var loan = new Loan()
                {
                    MemberId = loanDto.MemberId,
                    CheckOutDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(30)
                };

                _context.Loans.Add(loan);
                _context.SaveChanges();

                var newLoanInDb = _context.Loans
                    .Where(l => (l.MemberId == loan.MemberId && l.CheckOutDate == loan.CheckOutDate)).Single();

                var loanBook = new LoanBook()
                {
                    LoanId = newLoanInDb.Id,
                    BookId = loanDto.BookId
                };

                _context.LoanBooks.Add(loanBook);
                _context.SaveChanges();

                var viewModel = new LoanFormViewModel(newLoanInDb);

                return View("LoanForm", viewModel);
            }
            else
            {
                var loanBook = new LoanBook()
                {
                    LoanId = loanDto.Id,
                    BookId = loanDto.BookId
                };

                _context.LoanBooks.Add(loanBook);
                _context.SaveChanges();

                var loanInDb = _context.Loans.Single(l => l.Id == loanDto.Id);
                var viewModel = new LoanFormViewModel(loanInDb);

                return View("LoanForm", viewModel);
            }
        }
    }
}