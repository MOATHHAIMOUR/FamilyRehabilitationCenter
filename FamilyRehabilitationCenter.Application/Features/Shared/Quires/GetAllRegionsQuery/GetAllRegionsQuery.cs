using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery
{
    public class GetAllRegionsQuery : IRequest<ApiResponse<IEnumerable<RegionDTO>>>
    {

    }
}
