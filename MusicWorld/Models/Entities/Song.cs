using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }
        public string Author { get; set; }

        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public string UrlMp3 { get; set; }
        public int ArtistsId { get; set; }
        public Artist Artists { get; set; }

        public int AlbumsId { get; set; }
        public Album Albums { get; set; }
    }
}