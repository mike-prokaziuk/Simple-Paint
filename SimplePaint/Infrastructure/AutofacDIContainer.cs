using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Infrastructure
{
    static class AutofacDIContainer
    {
        public static IContainer Container { get; private set; }

        public static void AddBindings()
        {
            var builder = new ContainerBuilder();

            Container = builder.Build();
        }
    }
}
