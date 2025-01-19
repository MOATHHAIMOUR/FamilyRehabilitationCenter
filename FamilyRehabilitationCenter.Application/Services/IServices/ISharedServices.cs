using FamilyRehabilitationCenter.Application.Common.ResultPattern;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;

namespace FamilyRehabilitationCenter.Application.Services.IServices
{
    public interface ISharedServices
    {
        public Task<Result<IEnumerable<CountryDTO>>> GetAllCountriesAsync();
        public Task<Result<IEnumerable<RegionDTO>>> GetAllRegionsAsync();
        public Task<Result<IEnumerable<CityDTO>>> GetAllCitiesByRegionId(int RegionId);
        public Task<Result<IEnumerable<DistrictDTO>>> GetAllDistrictsByRegionIdByCityId(int RegionId, int CityId);
    }
}
