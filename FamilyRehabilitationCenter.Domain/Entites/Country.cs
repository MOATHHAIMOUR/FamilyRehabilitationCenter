namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Country
    {
        public int CountryId { get; set; } // Primary Key
        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Region> Regions { get; set; } = null!;

    }
}
