using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAppCoreWeb.Data;

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


    }
}