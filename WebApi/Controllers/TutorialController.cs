using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleLearn.TutorialController.Commands;
using SimpleLearn.WebApi.Common.ApiData;
using System;
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
        IService Service;

        public TutorialController(IMediator mediator, IService service)
        {
            _mediator = mediator;
            Service = service;
        }

        [Route("post")]
        [HttpPost]
        public async Task Post(ApiTutorial tutorial)
        {
            await _mediator.Send(new AddTutorialCommand { Name = tutorial.Name });
        }

        [Route("update")]
        [HttpPost]
        public async Task Update(Guid tutorialGuid)
        {
            Service.Do();
            await _mediator.Send(new UpdateTutorialCommand { Id = tutorialGuid });
        }
    }
}