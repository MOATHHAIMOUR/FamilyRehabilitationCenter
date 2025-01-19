namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantInsuranceInfo
    {


        public int ApplicantInsuranceInfoId { get; set; }
        public int ApplicantId { get; set; }
        public bool IsApplicantHasInsurance { get; set; }
        public int InsuranceTypeId { get; set; }
        public int InsuranceLevelId { get; set; }
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public Applicant Applicant { get; set; } = null!;
        public InsuranceType InsuranceType { get; set; } = null!;
        public InsuranceLevel InsuranceLevel { get; set; } = null!;
    }
}
