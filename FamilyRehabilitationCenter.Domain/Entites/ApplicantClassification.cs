namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantClassification
    {
        public int ApplicantClassificationId { get; set; }
        public int ApplicantClassificationTypeId { get; set; }
        public string? Notes { get; set; }

        // Navigation Properties
        public ApplicantClassificationType ApplicantClassificationType { get; set; } = null!;
    }
}
