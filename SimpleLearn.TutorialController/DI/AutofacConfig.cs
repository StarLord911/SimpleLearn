using Autofac;
using SimpleLearn.TutorialController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.TutorialController.DI
{
    public static class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder)
        {
            // Register your dependencies here
            builder.RegisterType<SService>().As<ISService>();
        }
    }
}
