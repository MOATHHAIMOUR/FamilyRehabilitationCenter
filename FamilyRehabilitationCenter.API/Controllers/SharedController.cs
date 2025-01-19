using FamilyRehabilitationCenter.API.Controllers.Base;
using FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllCountriesQuery;
using FamilyRehabilitationCenter.Application.Features.Shared.Quires.GetAllRegionsQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FamilyRehabilitationCenter.API.Controllers
{
    [Route("api/Shared")]
    [ApiController]
    public class SharedController(IMediator mediator) : AppController(mediator)
    {

        [HttpGet("Countries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCountries()
        {
            var response = await _mediator.Send(new GetAllCountriesQuery());

            return NewResult(response);
        }

        [HttpGet("Regions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllRegions()
        {
            var response = await _mediator.Send(new GetAllRegionsQuery());

            return NewResult(response);
        }


        [HttpGet("GetCitiesByRegionId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCitiesByRegionId([FromQuery] int RegionId)
        {
            var response = await _mediator.Send(new GetAllCititesByRegionIdQuery(RegionId));

            return NewResult(response);
        }

        [HttpGet("GetDistrictsByRegionId_CityId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllDistricts([FromQuery] int RegionId, [FromQuery] int CityId)
        {
            var response = await _mediator.Send(new GetAllDistrictsByRegionByCitiyId(RegionId, CityId));

            return NewResult(response);
        }

    }
}
