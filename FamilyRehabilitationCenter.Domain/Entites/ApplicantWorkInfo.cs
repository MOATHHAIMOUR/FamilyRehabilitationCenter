namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantWorkInfo
    {

        public int ApplicantWorkInfoId { get; set; }
        public bool IsWorking { get; set; }
        public bool IsRetired { get; set; }
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public Applicant Applicant { get; set; } = null!;
        public int ApplicantId { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
    }
}
