namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Relative
    {


        public int RelativeId { get; set; }
        public int ApplicantId { get; set; }
        public int RelativeTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ContactInfoId { get; set; }

        // Navigation Properties
        public Applicant Applicant { get; set; } = null!;
        public RelativeType RelativeType { get; set; } = null!;
        public ContactInfo ContactInfo { get; set; } = null!;
    }
}
