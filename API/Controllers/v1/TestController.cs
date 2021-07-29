using Domain.Model.v1.Teste;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Create([FromQuery] string name, string race, string weapon)
        {
            var dto = new RequestTest(name, race, weapon);
            var result = await _mediator.Send(dto);
            return Ok(result);
        }
    }
}
