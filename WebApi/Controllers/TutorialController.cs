using Microsoft.AspNetCore.Mvc;
using SimpleLearn.ServicesConnection;
using SimpleLearn.WebApi.Common.ApiData;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/tutorial")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private readonly IRabbitMqService _rabbitMqService;

        public TutorialController(IRabbitMqService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
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
        public void Post(ApiTutorial tutorial)
        {
            _rabbitMqService.SendMessage("ghbdtn");
        }
    }
}