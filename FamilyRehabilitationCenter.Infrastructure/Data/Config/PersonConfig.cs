using FamilyRehabilitationCenter.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.PersonId);
            builder.Property(p => p.NationalNo).IsRequired().HasMaxLength(10);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.SecondName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.ThirdName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.DateOfBirth).IsRequired();

            builder.Property(p => p.ActiveDateOfBirth).IsRequired()
                  .HasComputedColumnSql("DATEDIFF(DAY, DateOfBirth, GETDATE())", stored: false);

            builder.Property(p => p.Gender).IsRequired();

            builder.Property(p => p.PersonalImage).IsRequired();

            builder.HasOne(p => p.ContactInfo)
                   .WithOne(c => c.Person)
                   .HasForeignKey<Person>(p => p.ContactInfoId);

            builder.HasOne(p => p.User)
                   .WithOne(u => u.Person)
                   .HasForeignKey<User>(u => u.PersonId);
        }
    }
}
