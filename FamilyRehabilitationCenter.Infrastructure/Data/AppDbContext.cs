using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Infrastructure.Data.Config.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseRestrictDeleteBehavior();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        // DbSets for all entities
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicantClassification> ApplicantClassifications { get; set; }
        public DbSet<ApplicantClassificationType> ApplicantClassificationTypes { get; set; }
        public DbSet<ApplicantInsuranceInfo> ApplicantInsuranceInfos { get; set; }
        public DbSet<ApplicantLocationInfo> ApplicantLocations { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ApplicantParentInfo> ApplicantsParentsInfos { get; set; }
        public DbSet<ApplicantWorkInfo> ApplicantWorkInfos { get; set; }
        public DbSet<BirthLocation> BirthLocations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyFieldType> CompanyFieldTypes { get; set; }
        public DbSet<ApplicantsComplaints> ApplicantsComplaints { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EducationalInfo> EducationalInfos { get; set; }
        public DbSet<InsuranceLevel> InsuranceLevels { get; set; }
        public DbSet<InsuranceType> InsuranceTypes { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<MinistryEducation> MinistryEducations { get; set; }
        public DbSet<MinistryEducationLevel> MinistryEducationLevels { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ParentWorkInfo> ParentsWorksInfos { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<RelativeType> RelativeTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkSectorType> WorkSectorTypes { get; set; }


    }
}
