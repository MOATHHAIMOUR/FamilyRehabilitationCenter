using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantsParentsConfig : IEntityTypeConfiguration<ApplicantParentInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicantParentInfo> builder)
        {
            builder.HasKey(a => a.ApplicantParentInfoId);


            builder.HasOne(ap => ap.Parent)
                   .WithMany(p => p.ApplicantsParentsInfo)
                   .HasForeignKey(ap => ap.ParentId);

            builder.HasOne(ap => ap.Applicant)
                   .WithMany(a => a.Parents)
                   .HasForeignKey(ap => ap.ApplicantId);
        }
    }
}

