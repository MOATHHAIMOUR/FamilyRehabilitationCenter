using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using MediatR;

namespace FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllCountriesQuery
{
    public class GetAllCountriesQuery : IRequest<ApiResponse<IEnumerable<CountryDTO>>>
    {
    }
}
