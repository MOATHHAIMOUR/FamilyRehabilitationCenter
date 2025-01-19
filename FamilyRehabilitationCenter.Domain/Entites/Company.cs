namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Company
    {
        public int CompanyId { get; set; }
        public int CompanyFieldId { get; set; }
        public int WorkSectorId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public CompanyFieldType CompanyField { get; set; } = null!;
        public WorkSectorType WorkSector { get; set; } = null!;
        public ICollection<ApplicantWorkInfo> ApplicantsWorking { get; set; } = null!;
        public ICollection<ParentWorkInfo> ParentWorkInfo { get; set; } = null!;

    }
}
