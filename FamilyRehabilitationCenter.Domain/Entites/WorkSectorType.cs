namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class WorkSectorType
    {


        public int WorkSectorTypeId { get; set; }
        public string WorkSectorName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<Company> Companies { get; set; } = null!;

    }
}
