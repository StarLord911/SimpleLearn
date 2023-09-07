using SimpleLearn.Data.Tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.Persistance
{
    public class TutorialRepository : ITutorialRepository
    {
        public Task<IEnumerable<Tutorial>> GetTutorialsAsync()
        {
            var mock = new List<Tutorial>
            {
                new Tutorial { Id = Guid.NewGuid(), Name = "Урок 1", OwnerId = Guid.NewGuid() },
                new Tutorial { Id = Guid.NewGuid(), Name = "Урок 2", OwnerId = Guid.NewGuid() }
            };

            return Task.FromResult(mock.AsEnumerable());
        }
    }
}
