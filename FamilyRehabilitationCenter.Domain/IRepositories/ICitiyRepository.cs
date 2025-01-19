using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Domain.IRepositories.Base;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public interface ICitiyRepository : IGenericRepository<City>
    {
        public Task<IEnumerable<DTO>> GetAllCitiesByRegionIdAsync<DTO>(int RegionId);

    }
}
