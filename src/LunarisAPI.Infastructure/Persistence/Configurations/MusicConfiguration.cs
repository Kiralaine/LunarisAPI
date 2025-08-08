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
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.ToTable("Musics");
            builder.HasIndex(m => m.MusicId);
            builder.Property(m => m.Artist).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Title).IsRequired().HasMaxLength(70);
            builder.Property(m => m.Genre).HasMaxLength(60);
            builder.Property(m => m.Duration).IsRequired();
            builder.Property(m=>m.UploadDate).IsRequired().HasDefaultValueSql("UTC_TIMESTAMP()");
            builder.Property(m => m.FileID);
        }
    }
}
