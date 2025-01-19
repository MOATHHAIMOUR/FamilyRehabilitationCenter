namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Region
    {
        public int RegionId { get; set; } // Primary Key
        public int CountryId { get; set; } // Foreign Key

        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Population { get; set; }

        // Navigation Properties
        public Country Country { get; set; } = null!;
        public ICollection<City> Cities { get; set; } = null!;
        public ICollection<District> Districts { get; set; } = null!;


    }
}
