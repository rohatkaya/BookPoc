using BookPoc.Domain.Application;
using BookPoc.Domain.Application.Model.RequestModel;
using BookPoc.Host.RequestModel;
using Nancy;
using Nancy.ModelBinding;

namespace BookPoc.Host.Modules
{
    public class BookModule : NancyModule
    {
        private readonly BookAppService _bookAppService;
        public BookModule(BookAppService bookAppService)
        {
            _bookAppService = bookAppService;

            Get("/book/{id}", args => bookAppService.FindBook.FindById(args.id));
            Get("/book", args => _bookAppService.GetAllBooks.GetAll());
            Post("/book", args =>
            {
                var model = this.Bind<AddBookRequestModel>();
                var request = new AddBookRequest()
                {
                    Name = model.Name,
                    Description = model.Description,
                    AuthorId = model.AuthorId
                };

                return _bookAppService.AddBook.Add(request);
            });
        }

        
    }
}