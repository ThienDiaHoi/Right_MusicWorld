using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;
using MusicWorld.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {
        private IMusicReposity repository;
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public HomeController( IMusicReposity repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(
            new ProductListViewModel
            {
              
                Songs = repository.Songs
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)



            });
                




        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Album() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .OrderBy(a => a.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(a => a.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(a => a.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(a => a.Id)
                .Take(6)



            });
        public IActionResult Events() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .OrderBy(a => a.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(a => a.Id)
                ,
                Albums = repository.Albums
                .OrderBy(a => a.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(a => a.Id)
                .Take(6)
            });

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
