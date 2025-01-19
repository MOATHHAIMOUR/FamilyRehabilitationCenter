using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.CountryId);
            builder.Property(c => c.NameAr)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.NameEn)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Code)
                   .IsRequired()
                   .HasMaxLength(10);

        }
    }
}
