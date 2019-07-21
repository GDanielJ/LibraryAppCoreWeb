using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Data;
using LibraryAppCoreWeb.Models;
using LibraryAppCoreWeb.ViewModels;

namespace LibraryAppCoreWeb.Controllers
{
    public class MembersController : Controller
    {
        private ApplicationDbContext _context;

        public MembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var members = _context.Members.ToList();

            return View(members);
        }

        [HttpGet]
        public IActionResult New()
        {
            var viewModel = new MemberFormViewModel();

            return View("MemberForm", viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var memberInDb = _context.Members.SingleOrDefault(b => b.Id == id);

            if (memberInDb == null)
            {
                return NotFound();
            }

            var viewModel = new MemberFormViewModel(memberInDb);

            return View("MemberForm", viewModel);
        }

        [HttpPost]
        public IActionResult Save(Member member)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MemberFormViewModel(member);

                return View("MemberForm", viewModel);
            }

            if (member.Id == 0)
            {
                _context.Members.Add(member);
            }
            else
            {
                var memberInDb = _context.Members.Single(m => m.Id == member.Id);

                memberInDb.Firstname = member.Firstname;
                memberInDb.Lastname = member.Lastname;
            };

            _context.SaveChanges();

            return RedirectToAction("Index", "Members");
        }

        [HttpPost]
        public IActionResult DeleteMember(int id)
        {
            var memberInDb = _context.Members.SingleOrDefault(m => m.Id == id);

            if (memberInDb == null)
                return NotFound();

            _context.Remove(memberInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Members");
        }
    }
}