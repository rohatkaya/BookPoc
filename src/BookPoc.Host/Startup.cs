using Autofac;
using BookPoc.Domain;
using Microsoft.AspNetCore.Builder;
using Nancy.Owin;

namespace BookPoc.Host
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            var builder = new ContainerBuilder();
            
            BookBootStrapper.Startup(builder);

            var container = builder.Build();
            var bootstrapper = new NancyBootStrapper(container);

            app.UseOwin(x => x.UseNancy(options => options.Bootstrapper = bootstrapper));
        }
    }
}