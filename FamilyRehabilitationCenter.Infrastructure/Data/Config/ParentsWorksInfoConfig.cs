using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    internal class ParentsWorksInfoConfig : IEntityTypeConfiguration<ParentWorkInfo>
    {
        public void Configure(EntityTypeBuilder<ParentWorkInfo> builder)
        {
            builder.HasOne(pwi => pwi.Company)
              .WithOne()
              .HasForeignKey<ParentWorkInfo>(pwi => pwi.CompanyJobTitleId);

            // One-to-One with JobTitle
            builder.HasOne(pwi => pwi.JobTitle)
                   .WithOne()
                   .HasForeignKey<ParentWorkInfo>(pwi => pwi.JopTitleId);
        }
    }
}


