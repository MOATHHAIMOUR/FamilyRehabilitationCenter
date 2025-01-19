namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class EducationalInfo
    {

        public int EducationalInfoId { get; set; }
        public bool IsIlliterate { get; set; }
        public int MinistryEducationId { get; set; }
        public int EducationLevelId { get; set; }
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public MinistryEducation MinistryEducation { get; set; } = null!;
        public MinistryEducationLevel EducationLevel { get; set; } = null!;
    }
}
