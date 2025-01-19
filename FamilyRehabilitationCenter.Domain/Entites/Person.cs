namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Person
    {

        public int PersonId { get; set; }
        public required string NationalNo { get; set; }
        public required string FirstName { get; set; }
        public required string SecondName { get; set; }
        public required string ThirdName { get; set; }
        public required string LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required DateTime ActiveDateOfBirth { get; set; }
        //public required string LocationBirth { get; set; }
        public required bool Gender { get; set; }
        public required string PersonalImage { get; set; }

        // Navigation Properties
        public int ContactInfoId { get; set; }
        public ContactInfo ContactInfo { get; set; } = null!;

        public int NationalityId { get; set; }
        public Country Nationality { get; set; } = null!;

        public User? User { get; set; }
    }
}
