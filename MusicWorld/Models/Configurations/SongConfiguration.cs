using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Category).HasMaxLength(50).IsRequired();
            builder.Property(x => x.UrlImage).IsRequired();

            builder.HasOne(x => x.Artists).WithMany(x => x.Songs).HasForeignKey(x => x.ArtistsId);
            builder.HasOne(x => x.Albums).WithMany(x => x.Songs).HasForeignKey(x => x.AlbumsId);
        }
    }
}