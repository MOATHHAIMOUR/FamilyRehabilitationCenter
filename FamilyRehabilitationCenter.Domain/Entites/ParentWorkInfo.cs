namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ParentWorkInfo
    {

        public int ParentWorkInfoId { get; set; }
        public int ParentId { get; set; }
        public int JopTitleId { get; set; }
        public int CompanyJobTitleId { get; set; }
        public bool IsWorking { get; set; }
        public bool IsRetired { get; set; }
        public string WorkPhone { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public Parent Parent { get; set; } = null!;
        public JobTitle JobTitle { get; set; } = null!;
        public Company Company { get; set; } = null!;


    }
}
