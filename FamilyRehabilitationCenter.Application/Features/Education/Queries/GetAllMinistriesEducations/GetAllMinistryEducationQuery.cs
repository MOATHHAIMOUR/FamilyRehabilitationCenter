using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Education.Queries.GetAllMinistriesEducations
{
    public class GetAllMinistryEducationsQuery : IRequest<ApiResponse<IEnumerable<MinistryEducationDTO>>>
    {
    }
}
