using FamilyRehabilitationCenter.API.Controllers.Base;
using FamilyRehabilitationCenter.Application.Features.Education.Queries.GetAllMinistriesEducations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FamilyRehabilitationCenter.API.Controllers
{
    [Route("api/Shared")]
    [ApiController]
    public class MinistryEducationController(IMediator mediator) : AppController(mediator)
    {

        [HttpGet("MinistryEducations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllMinistryEducations()
        {
            var response = await _mediator.Send(new GetAllMinistryEducationsQuery());

            return NewResult(response);
        }

        [HttpGet("MinistryEducationLevelsByMinistryEducationId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllMinistryEducations([FromQuery] int MinistryEducationId)
        {
            var response = await _mediator.Send(new GetAllMinistryEducationLevlesByMinistryEducationTypeQuery(MinistryEducationId));

            return NewResult(response);
        }

    }
}
