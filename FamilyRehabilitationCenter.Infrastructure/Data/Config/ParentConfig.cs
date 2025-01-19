using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    internal class ParentConfig : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {

            builder.HasOne(p => p.Person)
            .WithOne()
            .HasForeignKey<Parent>(p => p.PersonId);




            // Foreign Key to EducationalInfo
            builder.HasOne(p => p.EducationInfo)
                   .WithOne()
                   .HasForeignKey<Parent>(p => p.EducationInfoId);

            // RelationType (Mother/Father)
            builder.Property(p => p.RelationType)
                   .IsRequired()
                   .HasComment("0 = Mother, 1 = Father");
        }
    }
}
