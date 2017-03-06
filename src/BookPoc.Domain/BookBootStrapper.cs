using System.Data;
using System.Reflection;
using Autofac;
using BookPoc.Domain.Application;
using BookPoc.Domain.Application.BusinessUseCases;
using BookPoc.Domain.Application.Queries;
using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Infrastructure.Base;

namespace BookPoc.Domain
{
    public static class BookBootStrapper
    {
        public static void Startup(ContainerBuilder builder)
        {
            builder.RegisterInstance(ConnectionFactory.Instance.GetConnection()).As<IDbConnection>().SingleInstance();

            RegisterServices(builder);
        }

        public static void RegisterServices(ContainerBuilder builder)
        {
            //Repositories
            var repositories = typeof(BookRepository).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(repositories).AsImplementedInterfaces();

            //Queries
            var queries = typeof(FindBook).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(queries).AsSelf();

            //Business UseCases
            var businessUseCases = typeof(AddBook).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(businessUseCases).AsSelf();

            //App Service
            builder.RegisterType<BookAppService>();
        }
    }
}