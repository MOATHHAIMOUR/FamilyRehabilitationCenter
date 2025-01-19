using FamilyRehabilitationCenter.Application.Common.ResultPattern;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;

namespace FamilyRehabilitationCenter.Application.Services.IServices
{
    public interface IMinistryEducationServices
    {
        public Task<Result<IEnumerable<MinistryEducationDTO>>> GetAllMinistryEducationAsync();
        public Task<Result<IEnumerable<MinistryEducationLevelDTO>>> GetAllMinistryEducationLevlesByMinistryEducationIdAsync(int MinistryEducationId);

    }
}
