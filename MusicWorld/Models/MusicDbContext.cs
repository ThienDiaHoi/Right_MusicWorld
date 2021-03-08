using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicWorld.Models.Configurations;
using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class MusicDbContext : IdentityDbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuration fluent Api
        
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());

            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.Entity<Song>().ToTable("Songs");
            modelBuilder.Entity<Artist>().ToTable("Artists");
            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<Album>().ToTable("Albums");
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}