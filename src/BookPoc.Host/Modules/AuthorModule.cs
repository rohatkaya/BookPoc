using BookPoc.Domain.Application;
using Nancy;

namespace BookPoc.Host.Modules
{
    public class AuthorModule : NancyModule
    {
        public AuthorModule(BookAppService service)
        {
            Get("/author", args => service.GetAllAuthors.GetAll());
        }
    }
}