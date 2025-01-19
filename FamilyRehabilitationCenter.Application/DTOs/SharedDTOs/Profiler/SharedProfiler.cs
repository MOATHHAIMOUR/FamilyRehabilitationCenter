using AutoMapper;
using FamilyRehabilitationCenter.Domain.Entites;

namespace FamilyRehabilitationCenter.Application.DTOs.SharedDTOs.ProfileR
{
    public class SharedProfiler : Profile
    {
        public SharedProfiler()
        {
            CreateMap<Country, CountryDTO>();
            CreateMap<Region, RegionDTO>();
            CreateMap<City, CityDTO>();
            CreateMap<District, DistrictDTO>();
        }
    }
}
