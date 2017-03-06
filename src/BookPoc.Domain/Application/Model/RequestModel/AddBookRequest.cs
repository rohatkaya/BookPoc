namespace BookPoc.Domain.Application.Model.RequestModel
{
    public class AddBookRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }

    }
}