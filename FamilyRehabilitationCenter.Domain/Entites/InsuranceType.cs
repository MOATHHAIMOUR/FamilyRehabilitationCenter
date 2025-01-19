namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class InsuranceType
    {
        public int InsuranceTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int WorkSectorId { get; set; }
        public int WorkTypeId { get; set; }
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<ApplicantInsuranceInfo>? ApplicantInsuranceInfo { get; set; }
        public ICollection<InsuranceLevel> InsuranceLevels { get; set; } = null!;
    }
}
