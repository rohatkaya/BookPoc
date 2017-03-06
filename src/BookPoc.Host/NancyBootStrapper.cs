using System.Reflection;
using Autofac;
using Nancy.Bootstrappers.Autofac;

namespace BookPoc.Host
{
    public class NancyBootStrapper : AutofacNancyBootstrapper
    {
        private readonly ILifetimeScope _lifetimeScope;

        public NancyBootStrapper(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        protected override ILifetimeScope GetApplicationContainer()
        {
            return _lifetimeScope;
        }
        protected override void ConfigureApplicationContainer(ILifetimeScope container)
        {
            base.ConfigureApplicationContainer(container);
        }
    }
}