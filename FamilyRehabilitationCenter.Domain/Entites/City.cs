namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class City
    {

        public int CityId { get; set; }
        public required string NameAr { get; set; }
        public required string NameEn { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; } = null!;
        public ICollection<District> Districts { get; set; } = new List<District>();


    }
}
