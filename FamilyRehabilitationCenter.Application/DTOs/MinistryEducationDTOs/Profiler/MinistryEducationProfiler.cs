using AutoMapper;
using FamilyRehabilitationCenter.Domain.Entites;

namespace FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs.Profiler
{
    public class MinistryEducationProfiler : Profile
    {
        public MinistryEducationProfiler()
        {
            CreateMap<MinistryEducation, MinistryEducationDTO>();

        }
    }
}
