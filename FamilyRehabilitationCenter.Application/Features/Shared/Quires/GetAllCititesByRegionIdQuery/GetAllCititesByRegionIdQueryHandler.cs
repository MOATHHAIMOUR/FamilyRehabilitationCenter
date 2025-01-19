using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllCititesByRegionIdQueryHandler : IRequestHandler<GetAllCititesByRegionIdQuery, ApiResponse<IEnumerable<CityDTO>>>
    {
        private readonly ISharedServices _sharedServices;

        public GetAllCititesByRegionIdQueryHandler(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        public async Task<ApiResponse<IEnumerable<CityDTO>>> Handle(GetAllCititesByRegionIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _sharedServices.GetAllCitiesByRegionId(request.CitiyId);
            return ApiResponseHandler.Success(result.Value ?? []);
        }
    }
}
