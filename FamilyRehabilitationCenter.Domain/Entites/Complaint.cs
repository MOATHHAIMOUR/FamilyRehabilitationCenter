namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Complaint
    {
        public int ComplaintId { get; set; } // Primary Key
        public string ComplaintName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Property
        public ICollection<ApplicantsComplaints> ApplicantsComplaints { get; set; } = new List<ApplicantsComplaints>();
    }
}