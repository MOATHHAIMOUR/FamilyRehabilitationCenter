using FamilyRehabilitationCenter.Application.Common.ApiResponse;
using FamilyRehabilitationCenter.Application.DTOs.SharedDTOs;
using FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllCountriesQuery;
using FamilyRehabilitationCenter.Application.Services.IServices;
using MediatR;

namespace FamilyRehabilitationCenter.API
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, ApiResponse<IEnumerable<CountryDTO>>>
    {
        private readonly ISharedServices _sharedServices;

        public GetAllCountriesQueryHandler(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        public async Task<ApiResponse<IEnumerable<CountryDTO>>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            return ApiResponseHandler.Success((await _sharedServices.GetAllCountriesAsync()).Value ?? []);
        }
    }
}
