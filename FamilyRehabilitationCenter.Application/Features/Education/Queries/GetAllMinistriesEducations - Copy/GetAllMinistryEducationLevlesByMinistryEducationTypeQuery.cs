using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Education.Queries.GetAllMinistriesEducations
{
    public class GetAllMinistryEducationLevlesByMinistryEducationTypeQuery : IRequest<ApiResponse<IEnumerable<MinistryEducationLevelDTO>>>
    {
        public GetAllMinistryEducationLevlesByMinistryEducationTypeQuery(int ministryEducationId)
        {
            MinistryEducationId = ministryEducationId;
        }

        public int MinistryEducationId { get; set; }
    }
}
