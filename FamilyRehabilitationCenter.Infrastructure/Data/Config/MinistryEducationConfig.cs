using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class MinistryEducationConfig : IEntityTypeConfiguration<MinistryEducation>
    {
        public void Configure(EntityTypeBuilder<MinistryEducation> builder)
        {
            // Relationships
            builder.HasMany(me => me.MinistryEducationLevels)
                   .WithOne(mel => mel.MinistryEducation)
                   .HasForeignKey(mel => mel.MinistryEducationId)
                   .IsRequired();
        }
    }
}
