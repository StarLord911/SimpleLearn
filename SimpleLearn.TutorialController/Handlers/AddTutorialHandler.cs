using MediatR;
using SimpleLearn.TutorialController.Commands;
using SimpleLearn.TutorialController.Services;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Handlers
{
    public class AddTutorialHandler : IRequestHandler<AddTutorialCommand, int>
    {
        private readonly ISService service;

        public AddTutorialHandler(ISService service)
        {
            this.service = service;
        }

        public Task<int> Handle(AddTutorialCommand request, CancellationToken cancellationToken)
        {
            service.Do();
            return Task.FromResult(5);
        }
    }
}