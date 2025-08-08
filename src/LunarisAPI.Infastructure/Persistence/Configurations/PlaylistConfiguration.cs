using LunarisAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarisAPI.Infastructure.Persistence.Configurations
{
    public class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("Playlists");
            builder.HasKey(p => p.PlaylistId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.CoverFileId);
            builder.HasMany(p => p.Musics).WithMany(m => m.Playlists).UsingEntity(j => j.ToTable("PlaylistMusics"));
            builder.Property(m => m.CreatedAt).IsRequired().HasDefaultValueSql("UTC_TIMESTAMP()");

        }
    }
}
