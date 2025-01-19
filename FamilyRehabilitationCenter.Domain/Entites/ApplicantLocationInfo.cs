namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class ApplicantLocationInfo
    {

        public int LocationInfoId { get; set; } // Primary Key
        public int CountryId { get; set; } // Foreign Key
        public int RegionId { get; set; } // Foreign Key
        public int CityId { get; set; } // Foreign Key
        public int ResidentialNeighborhoodId { get; set; } // Foreign Key
        public string Street { get; set; } = string.Empty;
        public string HomeNumber { get; set; } = string.Empty;

        // Navigation Properties
        public Country Country { get; set; } = null!;
        public Region Region { get; set; } = null!;
        public City City { get; set; } = null!;
        public District District { get; set; } = null!;




    }
}
