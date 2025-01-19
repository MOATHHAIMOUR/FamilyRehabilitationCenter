using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class ContactInfoConfig : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasKey(c => c.ContactInfoId);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(10);
            builder.Property(c => c.Phone2).HasMaxLength(10);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
        }
    }
}
