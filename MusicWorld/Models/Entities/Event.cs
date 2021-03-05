using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public Decimal TicketPrice { get; set; }
        public string Place { get; set; }
        public DateTime StartingDate { get; set; }

        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}