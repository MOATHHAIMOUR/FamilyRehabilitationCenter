namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class MinistryEducation
    {

        public int MinistryEducationId { get; set; }
        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<MinistryEducationLevel> MinistryEducationLevels { get; set; } = null!;
    }
}
