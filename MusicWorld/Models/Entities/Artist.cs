using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }

        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public int EventId { get; set; }
        public Event Events { get; set; }

        public ICollection<Song> Songs { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}