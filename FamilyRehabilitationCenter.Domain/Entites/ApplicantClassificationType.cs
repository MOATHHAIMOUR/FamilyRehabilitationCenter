namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantClassificationType
    {

        public int ApplicantClassificationTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<ApplicantClassification> ApplicantClassifications { get; set; } = null!;
    }
}
