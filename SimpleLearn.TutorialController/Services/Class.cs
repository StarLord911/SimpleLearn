using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.Services
{
    public class SService : ISService
    {
        public void Do()
        {
            
        }
    }

    public interface ISService
    {
        void Do();
    }
}
