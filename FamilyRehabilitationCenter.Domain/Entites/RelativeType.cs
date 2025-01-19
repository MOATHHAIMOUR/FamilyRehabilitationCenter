namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class RelativeType
    {

        public int RelativeTypeId { get; set; }
        public required string TypeName { get; set; }
        public ICollection<Relative> Relatives { get; set; } = null!;
    }
}
