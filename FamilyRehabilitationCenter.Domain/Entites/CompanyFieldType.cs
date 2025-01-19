namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class CompanyFieldType
    {
        public int CompanyFieldTypeId { get; set; }
        public required string FieldType { get; set; }

        public ICollection<Company> Companies { get; set; } = null!;
    }
}
