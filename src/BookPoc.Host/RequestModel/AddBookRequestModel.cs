namespace BookPoc.Host.RequestModel
{
    public class AddBookRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
    }
}