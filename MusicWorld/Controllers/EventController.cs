using Microsoft.AspNetCore.Mvc;
using MusicWorld.Models;
using MusicWorld.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Controllers
{
    public class EventController : Controller
    {
        private IMusicReposity repository;

        public EventController(IMusicReposity repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(
            new ProductListViewModel
            {
                Events = repository.Events
                .OrderBy(a => a.Id)

            });
        
        public IActionResult Detail(int eventId) => View(
            new ProductListViewModel
            {
                Events = repository.Events
                .Where(a => a.Id == eventId)
                .Take(1)

            });
        

     

    }
}
