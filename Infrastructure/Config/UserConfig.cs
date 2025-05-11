using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class UserConfig :IEntityTypeConfiguration<User>
{
        public void Configure(EntityTypeBuilder<User> builder)
        {
                builder.HasKey(u => u.Id);
                
                builder.Property(u => u.Username)
                        .IsRequired()
                        .HasMaxLength(50);

                builder.Property(u => u.Email)
                        .IsRequired()
                        .HasMaxLength(255);

                builder.Property(u => u.PasswordHash)
                        .IsRequired()
                        .HasMaxLength(255);
                
                builder.Property(u => u.Age)
                        .IsRequired(false);

                builder.Property(u => u.Role)
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasDefaultValueSql("User");
                
                builder.Property(x => x.CreatedAt)
                        .IsRequired()
                        .HasDefaultValueSql("getdate()");

                builder.Property(x => x.UpdatedAt)
                        .IsRequired(false);
        }
    
}