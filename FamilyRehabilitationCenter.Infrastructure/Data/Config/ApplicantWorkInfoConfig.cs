using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantWorkInfoConfig : IEntityTypeConfiguration<ApplicantWorkInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicantWorkInfo> builder)
        {

            builder.HasKey(a => a.ApplicantWorkInfoId);

            builder.HasOne(awi => awi.Applicant)
                   .WithMany(a => a.WorkInfos) // Each Applicant can have multiple work records
                   .HasForeignKey(awi => awi.ApplicantId)
                   .IsRequired(); // Each work info must reference an applicant

            // Relationship: Company
            builder.HasOne(awi => awi.Company)
                   .WithMany(c => c.ApplicantsWorking) // Each Company can have multiple applicants working
                   .HasForeignKey(awi => awi.CompanyId)
                   .IsRequired(false);

            // Relationship: JobTitle
            builder.HasOne(awi => awi.JobTitle)
                   .WithMany(jt => jt.ApplicantsWorkInfo) // Each JobTitle can be linked to multiple work records
                   .HasForeignKey(awi => awi.JobTitleId)
                   .IsRequired(false);
        }
    }
}
