using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllDistrictsByRegionByCitiyId : IRequest<ApiResponse<IEnumerable<DistrictDTO>>>
    {
        public GetAllDistrictsByRegionByCitiyId(int regionId, int cityId)
        {
            CityId = cityId;
            RegionId = regionId;
        }

        public int CityId { get; set; }

        public int RegionId { get; set; }
    }
}
