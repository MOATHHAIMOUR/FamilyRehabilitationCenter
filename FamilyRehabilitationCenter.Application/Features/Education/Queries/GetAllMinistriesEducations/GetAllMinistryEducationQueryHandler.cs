using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.MinistryEducationDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Education.Queries.GetAllMinistriesEducations
{
    public class GetAllMinistryEducationQueryHandler : IRequestHandler<GetAllMinistryEducationsQuery, ApiResponse<IEnumerable<MinistryEducationDTO>>>
    {
        private readonly IMinistryEducationServices _ministryEducationServices;

        public GetAllMinistryEducationQueryHandler(IMinistryEducationServices ministryEducationServices)
        {
            _ministryEducationServices = ministryEducationServices;
        }

        public async Task<ApiResponse<IEnumerable<MinistryEducationDTO>>> Handle(GetAllMinistryEducationsQuery request, CancellationToken cancellationToken)
        {
            return ApiResponseHandler.Success<IEnumerable<MinistryEducationDTO>>((await _ministryEducationServices.GetAllMinistryEducationAsync()).Value ?? []);
        }
    }
}
