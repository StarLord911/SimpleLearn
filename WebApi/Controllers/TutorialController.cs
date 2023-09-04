using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleLearn.TutorialController.Commands;
using SimpleLearn.WebApi.Common.ApiData;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/tutorial")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TutorialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TutorialController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TutorialController>
        [HttpPost]
        public async Task Post(ApiTutorial tutorial)
        {
            var res = await _mediator.Send(new AddTutorialCommand {Name = "AXMA" });
        }
    }
}