using MediatR;
using MediatRExample.MediatR.Commands.City.Create;
using MediatRExample.MediatR.Queries.City;
using MediatRExample.MediatR.Queries.City.GetAll;
using MediatRExample.MediatR.Queries.City.GetById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            var query = new GetAllCitiesQuery();

            return Ok(await _mediator.Send(query));
        }

        [Route("[action]/id")]
        [HttpGet]
        public async Task<IActionResult> GetCityById(Guid id) 
        {
            var query = new GetCityByIdQuery { Id = id };

            return Ok(await _mediator.Send(query));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
