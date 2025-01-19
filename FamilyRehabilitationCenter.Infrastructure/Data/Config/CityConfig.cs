using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.CityId);

            builder.Property(c => c.NameAr).IsRequired().HasMaxLength(30);

            builder.HasOne(c => c.Region)
              .WithMany(r => r.Cities)
              .HasForeignKey(c => c.RegionId)
              .IsRequired()
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
