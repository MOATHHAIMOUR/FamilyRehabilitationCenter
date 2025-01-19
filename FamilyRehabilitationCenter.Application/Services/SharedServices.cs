using FamilyRehabilitationCenter.Application.Common.ResultPattern;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using FamilyRehabilitationCenter.Domain.IRepositories;

namespace FamilyRehabilitationCenter.Application.Services
{
    public class SharedServices : ISharedServices
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly ICitiyRepository _citiyRepository;
        private readonly IDistrictRepository _districtRepository;

        public SharedServices(ICountryRepository countryRepository, IRegionRepository regionRepository, ICitiyRepository citiyRepository, IDistrictRepository districtRepository)
        {
            _countryRepository = countryRepository;
            _regionRepository = regionRepository;
            _citiyRepository = citiyRepository;
            _districtRepository = districtRepository;
        }

        public async Task<Result<IEnumerable<CityDTO>>> GetAllCitiesByRegionId(int RegionId)
        {
            return Result<IEnumerable<CityDTO>>.Success(await _citiyRepository.GetAllCitiesByRegionIdAsync<CityDTO>(RegionId));
        }

        public async Task<Result<IEnumerable<DistrictDTO>>> GetAllDistrictsByRegionIdByCityId(int RegionId, int CityId)
        {
            return Result<IEnumerable<DistrictDTO>>.Success(await _districtRepository.GetAllDistrictsByRegionIdByCityId<DistrictDTO>(RegionId, CityId));
        }

        public async Task<Result<IEnumerable<CountryDTO>>> GetAllCountriesAsync()
        {
            return Result<IEnumerable<CountryDTO>>.Success(await _countryRepository.GetAllAsync<CountryDTO>());
        }

        public async Task<Result<IEnumerable<RegionDTO>>> GetAllRegionsAsync()
        {
            return Result<IEnumerable<RegionDTO>>.Success(await _regionRepository.GetAllAsync<RegionDTO>());
        }
    }
}
