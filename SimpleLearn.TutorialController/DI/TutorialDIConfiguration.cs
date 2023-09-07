using Autofac;
using SimpleLearn.Persistance;
using SimpleLearn.TutorialController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.DI
{
    public static class TutorialDIConfiguration
    {
        public static void Configure(ContainerBuilder builder)
        {
            // Register your dependencies here
            builder.RegisterType<TutorialRepository>().As<ITutorialRepository>();
        }
    }
}
