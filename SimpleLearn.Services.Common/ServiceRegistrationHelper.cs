using Autofac;
using SimpleLearn.TutorialController.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.Services.Common
{
    public static class ServiceRegistrationHelper
    {
        public static void Register(ContainerBuilder builder)
        {
            TutorialDIConfiguration.Configure(builder);

        }
    }
}
