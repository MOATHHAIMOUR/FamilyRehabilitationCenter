namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class JobTitle
    {

        public int JobTitleId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Properties

        public ICollection<ApplicantWorkInfo>? ApplicantsWorkInfo { get; set; }
        public ICollection<ParentWorkInfo>? ParentsWorksInfos { get; set; }


    }
}
