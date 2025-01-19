using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class RelativeConfig : IEntityTypeConfiguration<Relative>
    {
        public void Configure(EntityTypeBuilder<Relative> builder)
        {


            builder.HasOne(r => r.ContactInfo)
                   .WithOne(a => a.Relative)
                   .HasForeignKey<ContactInfo>(r => r.ContactInfoId)
                   .IsRequired();

            builder.HasOne(r => r.Applicant)
                   .WithMany(a => a.Relatives)
                   .HasForeignKey(r => r.ApplicantId);

            builder.HasOne(r => r.RelativeType)
                   .WithMany(rt => rt.Relatives)
                   .HasForeignKey(r => r.RelativeId)
                   .IsRequired();
        }
    }
}


