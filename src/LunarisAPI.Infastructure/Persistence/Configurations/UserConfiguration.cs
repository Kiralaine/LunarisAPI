

using LunarisAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LunarisAPI.Infastructure.Persistence.Configurations
{
    public  class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.UserId);

            // Username confs
            builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.Username).IsUnique();

            //Picture Conf
            builder.Property(u => u.ProfilePictureURL).HasMaxLength(500);

            // Email Confs
            builder.Property(u => u.Email).IsRequired().HasMaxLength(60);
            builder.HasIndex(u => u.Email).IsUnique();

            // Name conf
            builder.Property(u => u.Firstname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Lastname).IsRequired(false).HasMaxLength(50);

            // Bio conf
            builder.Property(u => u.Bio).IsRequired(false).HasMaxLength(255);


            // Configuration for user when he/she creates account
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("UTC_TIMESTAMP()");


            //Relationships confs
            builder.HasMany(u => u.RefreshTokens).WithOne(rt => rt.User).HasForeignKey(rf => rf.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Playlists).WithOne(p => p.User).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
