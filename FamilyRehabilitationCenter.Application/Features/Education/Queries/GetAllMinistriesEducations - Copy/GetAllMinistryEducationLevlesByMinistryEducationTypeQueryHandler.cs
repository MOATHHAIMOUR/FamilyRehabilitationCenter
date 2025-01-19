using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Education.Queries.GetAllMinistriesEducations
{
    public class GetAllMinistryEducationLevlesByMinistryEducationTypeQueryHandler : IRequestHandler<GetAllMinistryEducationLevlesByMinistryEducationTypeQuery, ApiResponse<IEnumerable<MinistryEducationLevelDTO>>>
    {
        private readonly IMinistryEducationServices _ministryEducationServices;

        public GetAllMinistryEducationLevlesByMinistryEducationTypeQueryHandler(IMinistryEducationServices ministryEducationServices)
        {
            _ministryEducationServices = ministryEducationServices;
        }

        public async Task<ApiResponse<IEnumerable<MinistryEducationLevelDTO>>> Handle(GetAllMinistryEducationLevlesByMinistryEducationTypeQuery request, CancellationToken cancellationToken)
        {
            return ApiResponseHandler.Success<IEnumerable<MinistryEducationLevelDTO>>((await _ministryEducationServices.GetAllMinistryEducationLevlesByMinistryEducationIdAsync(request.MinistryEducationId)).Value ?? []);
        }
    }
}
