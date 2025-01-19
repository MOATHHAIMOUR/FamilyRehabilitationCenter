namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class BirthLocation
    {

        public int BirthLocationId { get; set; } // Primary Key

        // Navigation Properties
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        // Navigation Properties
        public Country Country { get; set; } = null!;
        public Region Region { get; set; } = null!;
        public City City { get; set; } = null!;


    }
}
