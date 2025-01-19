using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    internal class ApplicantClassificationConfig : IEntityTypeConfiguration<ApplicantClassification>
    {
        public void Configure(EntityTypeBuilder<ApplicantClassification> builder)
        {

            builder.HasKey(a => a.ApplicantClassificationId);

            builder.HasOne(ac => ac.ApplicantClassificationType)
                   .WithMany(ct => ct.ApplicantClassifications)
                   .HasForeignKey(ac => ac.ApplicantClassificationTypeId)
                   .IsRequired();
        }
    }
}
