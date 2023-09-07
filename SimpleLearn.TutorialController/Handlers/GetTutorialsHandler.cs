using MediatR;
using SimpleLearn.Data.Tutorial;
using SimpleLearn.Persistance;
using SimpleLearn.TutorialController.Queryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Handlers
{
    public class GetTutorialsHandler : IRequestHandler<GetTutorialsQuery, IEnumerable<Tutorial>>
    {
        private readonly ITutorialRepository _tutorialRepository;

        public GetTutorialsHandler(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }
        public async Task<IEnumerable<Tutorial>> Handle(GetTutorialsQuery request, CancellationToken cancellationToken)
        {
            return await _tutorialRepository.GetTutorialsAsync();
        }
    }
}
