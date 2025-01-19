using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // Relationship: Each Company has one CompanyFieldType
            builder.HasOne(c => c.CompanyField)
                   .WithMany(cft => cft.Companies) // Each CompanyFieldType has many Companies
                   .HasForeignKey(c => c.CompanyFieldId)
                   .IsRequired();

            // Relationship: Each Company has one WorkSectorType
            builder.HasOne(c => c.WorkSector)
                   .WithMany(wst => wst.Companies) // Each WorkSectorType has many Companies
                   .HasForeignKey(c => c.WorkSectorId)
                   .IsRequired();
        }
    }
}
