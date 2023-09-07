using MediatR;

namespace SimpleLearn.TutorialController.Commands
{
    public class AddTutorialCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}