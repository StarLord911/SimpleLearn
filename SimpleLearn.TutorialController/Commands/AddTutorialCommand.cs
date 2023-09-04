using MediatR;
using SimpleLearn.TutorialController.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Commands
{
    public class AddTutorialCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
