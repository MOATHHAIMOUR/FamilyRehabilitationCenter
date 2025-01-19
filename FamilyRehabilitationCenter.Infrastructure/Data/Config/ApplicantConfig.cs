using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ApplicantConfig : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {

            builder.HasKey(a => a.ApplicantId);

            builder.Property(a => a.ApplicantId)
            .ValueGeneratedNever();

            builder.HasOne(a => a.User)
                  .WithOne()
                  .HasForeignKey<Applicant>(a => a.UserId)
                  .IsRequired();


            builder.HasOne(a => a.ApplicantClassification)
                   .WithOne()
                   .HasForeignKey<Applicant>(a => a.ClassificationId)
                   .IsRequired();

            builder.HasOne(a => a.EducationalInfo)
                   .WithOne()
                   .HasForeignKey<Applicant>(a => a.EducationalInfoId)
                   .IsRequired();

            builder.HasOne(a => a.ApplicantLocation)
                   .WithOne()
                   .HasForeignKey<Applicant>(a => a.ApplicantLocationId)
                   .IsRequired();

            builder.HasOne(ai => ai.BirthLocation)
               .WithMany()
               .HasForeignKey(ai => ai.BirthLocationId)
               .IsRequired();





            builder.
                HasMany(a => a.WorkInfos)
                   .WithOne(w => w.Applicant)
                   .HasForeignKey(w => w.ApplicantId)
                   .IsRequired();


            builder.HasMany(a => a.Relatives)
                   .WithOne(r => r.Applicant)
                   .HasForeignKey(r => r.ApplicantId)
                   .IsRequired();

            builder.HasMany(a => a.ApplicantsComplaints)
                   .WithOne(c => c.Applicant)
                   .HasForeignKey(c => c.ApplicantId)
                   .IsRequired();

            builder.HasMany(a => a.ApplicantInsuranceInfo)
                   .WithOne(i => i.Applicant)
                   .HasForeignKey(i => i.ApplicantId)
                   .IsRequired();
        }
    }
}
