namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ContactInfo
    {

        public int ContactInfoId { get; set; }
        public required string Phone { get; set; }
        public string? Phone2 { get; set; }
        public required string Email { get; set; }

        // Navigation Properties
        public Person Person { get; set; } = null!;
        public Relative Relative { get; set; } = null!;
    }
}
