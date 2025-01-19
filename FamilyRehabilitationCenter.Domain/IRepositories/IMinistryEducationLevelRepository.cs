using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Domain.IRepositories.Base;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public interface IMinistryEducationLevelRepository : IGenericRepository<MinistryEducationLevel>
    {
        public Task<IEnumerable<DTO>> GetAllMinistryEducationLevlesByMinistryEducationId<DTO>(int MinistryEducationId);
    }
}
