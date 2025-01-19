using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class DistrictConfig : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(r => r.DistrictId);
            builder.Property(r => r.NameAr).IsRequired().HasMaxLength(100);


            builder.HasOne(d => d.City)
                   .WithMany(c => c.Districts)
                   .HasForeignKey(d => d.CityId)
                   .IsRequired();
        }
    }
}
