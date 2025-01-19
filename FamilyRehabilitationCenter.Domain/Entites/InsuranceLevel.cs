namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class InsuranceLevel
    {
        public int InsuranceLevelId { get; set; }
        public int InsuranceTypeId { get; set; }
        public string Level { get; set; } = string.Empty;

        // Navigation Property
        public InsuranceType InsuranceType { get; set; } = null!;
        public ICollection<ApplicantInsuranceInfo> InsuranceInfos { get; set; } = null!;

    }
}
