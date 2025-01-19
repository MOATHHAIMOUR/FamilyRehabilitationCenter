namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantParentInfo
    {
        public int ApplicantParentInfoId { get; set; }

        public int ParentId { get; set; }

        public int ApplicantId { get; set; }
        public Parent Parent { get; set; } = null!;
        public Applicant Applicant { get; set; } = null!;

    }
}
