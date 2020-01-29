using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    public class Upcoming_BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adventure()
        {
            return View();
        }

        public IActionResult Biography()
        {
            return View();
        }

        public IActionResult Fiction()
        {
            return View();
        }

        public IActionResult Mistery()
        {
            return View();
        }
    }
}