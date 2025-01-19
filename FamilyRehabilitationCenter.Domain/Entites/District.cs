namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class District
    {
        public int DistrictId { get; set; }
        public required string NameAr { get; set; }
        public required string NameEn { get; set; }


        public int RegionId { get; set; } // Foreign Key
        public Region Region { get; set; } = null!;

        // Navigation Properties
        public int CityId { get; set; }
        public City City { get; set; } = null!;

    }
}
