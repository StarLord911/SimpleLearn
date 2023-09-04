using MediatR;
using SimpleLearn.TutorialController.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Commands.Handlers
{
    public class AddTutorialHandler : IRequestHandler<AddTutorialCommand, int>
    {
        public AddTutorialHandler()
        {
        }

        public Task<int> Handle(AddTutorialCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(5);
        }
    }
}
