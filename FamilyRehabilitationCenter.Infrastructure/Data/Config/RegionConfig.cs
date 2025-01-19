using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class RegionConfig : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(p => p.RegionId);
            builder.Property(p => p.NameAr).IsRequired().HasMaxLength(100);

            builder.HasKey(r => r.RegionId);

            builder.HasOne(r => r.Country)
                   .WithMany(c => c.Regions)
                   .HasForeignKey(r => r.CountryId)
                   .IsRequired();

            builder.HasMany(r => r.Districts)
                 .WithOne(c => c.Region)
                 .HasForeignKey(r => r.RegionId)
                 .IsRequired();
        }
    }
}
