using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Commands
{
    public class UpdateTutorialCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
