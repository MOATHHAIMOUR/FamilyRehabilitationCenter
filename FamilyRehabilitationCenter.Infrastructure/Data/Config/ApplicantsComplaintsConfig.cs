using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantsComplaintsConfig : IEntityTypeConfiguration<ApplicantsComplaints>
    {
        public void Configure(EntityTypeBuilder<ApplicantsComplaints> builder)
        {
            builder.HasKey(ac => ac.ApplicantComplaintId);

            // Configure Applicant Relationship
            builder.HasOne(ac => ac.Applicant)
                   .WithMany(a => a.ApplicantsComplaints)
                   .HasForeignKey(ac => ac.ApplicantId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Configure Complaint Relationship
            builder.HasOne(ac => ac.Complaint)
                   .WithMany(c => c.ApplicantsComplaints)
                   .HasForeignKey(ac => ac.ComplaintTypeId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
