namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class MinistryEducationLevel
    {
        public int MinistryEducationLevelId { get; set; }
        public int MinistryEducationId { get; set; }
        public string LevelAr { get; set; } = string.Empty;
        public string LevelEn { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Navigation Property
        public MinistryEducation MinistryEducation { get; set; } = null!;
    }
}
