using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllDistrictsByRegionByCitiyIdHandler : IRequestHandler<GetAllDistrictsByRegionByCitiyId, ApiResponse<IEnumerable<DistrictDTO>>>
    {
        private readonly ISharedServices _sharedServices;

        public GetAllDistrictsByRegionByCitiyIdHandler(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        public async Task<ApiResponse<IEnumerable<DistrictDTO>>> Handle(GetAllDistrictsByRegionByCitiyId request, CancellationToken cancellationToken)
        {
            var result = await _sharedServices.GetAllDistrictsByRegionIdByCityId(request.RegionId, request.CityId);

            return ApiResponseHandler.Success(result.Value ?? []);
        }
    }
}
