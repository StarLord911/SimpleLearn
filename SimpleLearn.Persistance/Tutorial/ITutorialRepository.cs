using SimpleLearn.Data.Tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.Persistance
{
    public interface ITutorialRepository
    {
        Task<IEnumerable<Tutorial>> GetTutorialsAsync();
    }
}
