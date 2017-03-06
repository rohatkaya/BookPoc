using System;
using System.Data;
using Autofac;

namespace BookPoc.Domain.BootstrapperTest
{
    public class BootStrapper
    {
        private static IConnectionContext _context;
        public static IConnectionContext ConnectionContext => _context;

        private static IContainer _container;
        public static IContainer Container => _container;

        public static void Startup(bool test = false)
        {
            RefreshRegister(test);

            if (!test)
                RegisterMappings();
        }

        private static void RegisterMappings()
        {
            throw new System.NotImplementedException();
        }

        public static void RefreshRegister(bool test = false)
        {
            _context = ConnectionFactory.Instance.CreateContext(test);
            var builder = new ContainerBuilder();
            builder.RegisterInstance(_context.OpenConnection()).As<IDbConnection>().SingleInstance();

            RegisterServices();

            _container = builder.Build();
        }

        private static void RegisterServices()
        {
            throw new NotImplementedException();
        }
    }
}