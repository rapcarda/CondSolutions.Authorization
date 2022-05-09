using CondSolutions.Authorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CondSolutions.Authorization.Mappings
{
    public class RefreshTokenMapping : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.ExpiryDate)
                .HasColumnType("smalldatetime");

            builder.Property(e => e.TokenHash)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(e => e.TokenSalt)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(e => e.Ts)
                .HasColumnType("smalldatetime")
                .HasColumnName("TS");

            builder.HasOne(d => d.User)
                .WithMany(p => p.RefreshTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RefreshToken_User");

            builder.ToTable(nameof(RefreshToken));
        }
    }
}
