using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantInsuranceInfoConfig : IEntityTypeConfiguration<ApplicantInsuranceInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicantInsuranceInfo> builder)
        {
            builder.HasKey(a => a.ApplicantInsuranceInfoId);


            // Relationship: InsuranceType
            builder.HasOne(aii => aii.InsuranceType)
                   .WithMany(it => it.ApplicantInsuranceInfo) // Each InsuranceType can have many InsuranceInfos
                   .HasForeignKey(aii => aii.InsuranceTypeId)
                   .IsRequired(); // Each ApplicantInsuranceInfo must reference an InsuranceType

            // Relationship: InsuranceLevel
            builder.HasOne(aii => aii.InsuranceLevel)
                   .WithMany(il => il.InsuranceInfos) // Each InsuranceLevel can have many InsuranceInfos
                   .HasForeignKey(aii => aii.InsuranceLevelId)
                   .IsRequired(); // Each ApplicantInsuranceInf

        }
    }
}
