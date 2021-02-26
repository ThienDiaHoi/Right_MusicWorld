using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Elements()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
