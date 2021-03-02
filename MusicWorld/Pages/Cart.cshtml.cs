using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicWorld.Models;
using MusicWorld.Intrastructure;
using MusicWorld.Models.ViewModel;
using MusicWorld.Models.Entities;

namespace MusicWorld.Pages
{
    public class CartModel : PageModel
    {
        private IMusicReposity repository;

        public CartModel(IMusicReposity repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(string titleID, string returnUrl)
        {
            Event title = repository.Events
                .FirstOrDefault(p => p.Title == titleID);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(title, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

