using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MusicWorld.Models.ViewModel
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Event events, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Event.Title == events.Title)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Event = events,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Event events) =>
            Lines.RemoveAll(l => l.Event.Title == events.Title);

        //public decimal ComputeTotalValue() =>
            //Lines.Sum(e => e.Event.Id * e.Quantity);

        public void Clear() => Lines.Clear();

    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Event Event { get; set; }
        public int Quantity { get; set; }
    }
}

