using System.Data;
using Autofac;
using BookPoc.Domain.Application;
using BookPoc.Domain.Model;
using NUnit.Framework;
using ServiceStack.OrmLite;

namespace BookPoc.Domain.Tests.Base
{
    public abstract class TestBase
    {
        protected BookAppService BookAppService;
        protected IContainer Container;

        [SetUp]
        public void BaseSetup()
        {
            var context = new InMemoryDatabase();

            //Register
            var builder = new ContainerBuilder();
            builder.RegisterInstance(context.OpenConnection()).As<IDbConnection>().SingleInstance();
            BookBootStrapper.RegisterServices(builder);
            Container = builder.Build();
            BookAppService = Container.Resolve<BookAppService>();

            //Initialize Db
            using (var db = context.OpenConnection())
            {
                db.CreateTableIfNotExists<Book>();
                db.CreateTableIfNotExists<Author>();
            }
            
        }
    }
}