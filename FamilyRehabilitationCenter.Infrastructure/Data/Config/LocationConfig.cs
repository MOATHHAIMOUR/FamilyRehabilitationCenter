using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class LocationConfig : IEntityTypeConfiguration<ApplicantLocationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicantLocationInfo> builder)
        {
            builder.HasKey(l => l.LocationInfoId);

            builder.Property(l => l.Street)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.HomeNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne(l => l.Country)
                   .WithMany()
                   .HasForeignKey(l => l.CountryId)
                   .IsRequired();

            builder.HasOne(l => l.Region)
                   .WithMany()
                   .HasForeignKey(l => l.RegionId)
                   .IsRequired();

            builder.HasOne(l => l.City)
                   .WithMany()
                   .HasForeignKey(l => l.CityId)
                   .IsRequired();


        }
    }
}
