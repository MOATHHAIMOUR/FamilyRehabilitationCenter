using FamilyRehabilitationCenter.Application.Common.ResultPattern;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using FamilyRehabilitationCenter.Domain.IRepositories;

namespace FamilyRehabilitationCenter.Application.Services
{
    public class MinistryEducationServices : IMinistryEducationServices
    {
        private readonly IMinistryEducationRepository _ministryEducationRepository;
        private readonly IMinistryEducationLevelRepository _ministryEducationLevelRepository;

        public MinistryEducationServices(IMinistryEducationRepository ministryEducationRepository, IMinistryEducationLevelRepository ministryEducationLevelRepository)
        {
            _ministryEducationRepository = ministryEducationRepository;
            _ministryEducationLevelRepository = ministryEducationLevelRepository;
        }

        public async Task<Result<IEnumerable<MinistryEducationDTO>>> GetAllMinistryEducationAsync()
        {
            return Result<IEnumerable<MinistryEducationDTO>>.Success(await _ministryEducationRepository.GetAllAsync<MinistryEducationDTO>());
        }

        public async Task<Result<IEnumerable<MinistryEducationLevelDTO>>> GetAllMinistryEducationLevlesByMinistryEducationIdAsync(int MinistryEducationId)
        {
            return Result<IEnumerable<MinistryEducationLevelDTO>>.Success(await _ministryEducationLevelRepository.GetAllMinistryEducationLevlesByMinistryEducationId<MinistryEducationLevelDTO>(MinistryEducationId));
        }
    }
}
