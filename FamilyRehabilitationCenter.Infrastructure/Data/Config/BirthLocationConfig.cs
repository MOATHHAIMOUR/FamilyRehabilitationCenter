using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class BirthLocationConfig : IEntityTypeConfiguration<BirthLocation>
    {
        public void Configure(EntityTypeBuilder<BirthLocation> builder)
        {
            builder.HasKey(bl => bl.BirthLocationId);

            builder.HasKey(bl => bl.BirthLocationId);

            // Configure Country Relationship
            builder.HasOne(bl => bl.Country)
                   .WithMany()
                   .HasForeignKey(bl => bl.CountryId)
                   .IsRequired();

            // Configure Province Relationship
            builder.HasOne(bl => bl.Region)
                   .WithMany()
                   .HasForeignKey(bl => bl.RegionId)
                   .IsRequired();

            // Configure City Relationship
            builder.HasOne(bl => bl.City)
                   .WithMany()
                   .HasForeignKey(bl => bl.CityId)
                   .IsRequired();
        }
    }
}
