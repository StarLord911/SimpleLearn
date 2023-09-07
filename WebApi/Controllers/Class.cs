using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class Service : IService
    {
        public void Do()
        {
            
        }
    }

    public interface IService
    {
        void Do();
    }
}
