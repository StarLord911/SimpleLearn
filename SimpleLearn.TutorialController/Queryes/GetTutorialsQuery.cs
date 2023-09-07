using MediatR;
using SimpleLearn.Data.Tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Queryes
{
    public class GetTutorialsQuery : IRequest<IEnumerable<Tutorial>>
    {
    }
}
