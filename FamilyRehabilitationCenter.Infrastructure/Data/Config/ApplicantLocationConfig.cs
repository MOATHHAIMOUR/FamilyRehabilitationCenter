using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantLocationConfig : IEntityTypeConfiguration<ApplicantLocationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicantLocationInfo> builder)
        {

            builder.HasKey(ali => ali.LocationInfoId);

            builder.HasOne(ali => ali.Country)
                   .WithMany()
                   .HasForeignKey(ali => ali.CountryId)
                   .IsRequired();

            builder.HasOne(ali => ali.Region)
                   .WithMany()
                   .HasForeignKey(ali => ali.RegionId)
                   .IsRequired();

            builder.HasOne(ali => ali.City)
                   .WithMany()
                   .HasForeignKey(ali => ali.CityId)
                   .IsRequired();

            builder.HasOne(ali => ali.District)
                   .WithMany()
                   .HasForeignKey(ali => ali.ResidentialNeighborhoodId)
                   .IsRequired();
        }
    }
}
