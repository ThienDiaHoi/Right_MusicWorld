using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class EFMusicRepository : IMusicReposity
    {
        public MusicDbContext context;

        public EFMusicRepository(MusicDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Song> Songs => context.Songs;
        public IQueryable<Artist> Artists => context.Artists;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Event> Events => context.Events;

    }
}