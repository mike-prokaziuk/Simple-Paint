using Autofac;
using SimplePaint.Implementation;
using SimplePaint.Interfaces;

namespace SimplePaint.Infrastructure
{
    static class AutofacDIContainer
    {
        public static IContainer Container { get; private set; }

        public static void AddBindings()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Painter>().As<IPainter>();
            builder.RegisterType<Canvas>().SingleInstance().As<ICanvas>();
            Container = builder.Build();
            //
            builder = new ContainerBuilder();
            builder.RegisterType<Editor>().As<IEditor>()
                .WithParameter("canvas",Container.Resolve<ICanvas>());
            builder.Update(Container);
        }
    }
}
