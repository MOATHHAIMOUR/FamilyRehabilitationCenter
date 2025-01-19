namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantsComplaints
    {
        public int ApplicantComplaintId { get; set; } // Primary Key
        public int ApplicantId { get; set; } // Foreign Key
        public int ComplaintTypeId { get; set; } // Foreign Key
        public string Notes { get; set; } = string.Empty;

        // Navigation Properties
        public Applicant Applicant { get; set; } = null!;
        public Complaint Complaint { get; set; } = null!;
    }
}
