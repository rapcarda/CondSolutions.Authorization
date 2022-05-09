using CondSolutions.Authorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CondSolutions.Authorization.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(e => e.PasswordSalt)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Ts)
                .HasColumnType("smalldatetime")
                .HasColumnName("TS");

            builder.ToTable(nameof(User));
        }
    }
}
