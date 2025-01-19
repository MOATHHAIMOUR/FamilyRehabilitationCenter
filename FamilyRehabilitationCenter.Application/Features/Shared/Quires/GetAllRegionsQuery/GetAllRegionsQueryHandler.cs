using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllRegionsQueryHandler : IRequestHandler<GetAllRegionsQuery, ApiResponse<IEnumerable<RegionDTO>>>
    {
        private readonly ISharedServices _sharedServices;

        public GetAllRegionsQueryHandler(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        public async Task<ApiResponse<IEnumerable<RegionDTO>>> Handle(GetAllRegionsQuery request, CancellationToken cancellationToken)
        {
            var result = await _sharedServices.GetAllRegionsAsync();

            return ApiResponseHandler.Success(result.Value ?? []);
        }
    }
}
