namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Parent
    {

        public int ParentId { get; set; } // Primary Key
        public int PersonId { get; set; } // Foreign Key to Person
        public int EducationInfoId { get; set; } // Foreign Key to EducationalInfo
        public bool RelationType { get; set; } // 0 = Mother, 1 = Father

        // Navigation Properties
        public Person Person { get; set; } = null!;
        public EducationalInfo EducationInfo { get; set; } = null!;
        public ICollection<ApplicantParentInfo> ApplicantsParentsInfo { get; set; } = null!;
        public ICollection<ParentWorkInfo> ParentsWorksInfos { get; set; } = null!;
    }
}
