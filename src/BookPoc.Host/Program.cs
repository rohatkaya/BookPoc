using System;
using System.IO;
using BookPoc.Domain;
using BookPoc.Domain.Application.BusinessUseCases;
using BookPoc.Domain.Application.Model.RequestModel;
using BookPoc.Domain.Application.Queries;
using Microsoft.AspNetCore.Hosting;

namespace BookPoc.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                 .UseContentRoot(Directory.GetCurrentDirectory())
                 .UseKestrel()
                 .UseStartup<Startup>()
                 .Build();

            host.Run();
        }
        
    }
}
