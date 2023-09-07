using MediatR;
using SimpleLearn.TutorialController.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Handlers
{
    public class UpdateTutorialHandler : IRequestHandler<UpdateTutorialCommand>
    {
        public Task<Unit> Handle(UpdateTutorialCommand request, CancellationToken cancellationToken)
        {

            return Unit.Task;
        }
    }
}
