using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class InsuranceTypeConfig : IEntityTypeConfiguration<InsuranceType>
    {
        public void Configure(EntityTypeBuilder<InsuranceType> builder)
        {
            // One-to-Many Relationship: InsuranceType to InsuranceLevel
            builder.HasMany(it => it.InsuranceLevels)
                   .WithOne(il => il.InsuranceType) // Each InsuranceLevel references one InsuranceType
                   .HasForeignKey(il => il.InsuranceTypeId)
                   .IsRequired(); // Each InsuranceLevel must reference an InsuranceType
        }
    }
}
