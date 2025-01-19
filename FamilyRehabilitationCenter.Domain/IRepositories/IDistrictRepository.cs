using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Domain.IRepositories.Base;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public interface IDistrictRepository : IGenericRepository<District>
    {
        public Task<IEnumerable<DTO>> GetAllDistrictsByRegionIdByCityId<DTO>(int RegionId, int CityId);

    }
}
