using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllCititesByRegionIdQuery : IRequest<ApiResponse<IEnumerable<CityDTO>>>
    {
        public GetAllCititesByRegionIdQuery(int citiyId)
        {
            CitiyId = citiyId;
        }
        public int CitiyId { get; set; }

    }
}
