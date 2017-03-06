using BookPoc.Domain.Application;
using BookPoc.Domain.Application.Model.RequestModel;
using BookPoc.Domain.Tests.Base;
using NUnit.Framework;

namespace BookPoc.Domain.Tests.Application.Queries
{
    [TestFixture]
    public class GetAllBooksTest : TestBase
    {
        [Test]
        public void GetAllTest_GetAll_Successfully()
        {
            //Arrange
            var request1 = new AddBookRequest() {Name = "Test", Description = "Test", AuthorId = 1};
            BookAppService.AddBook.Add(request1);

            var books = BookAppService.GetAllBooks.GetAll();
            Assert.IsNotNull(books);
            Assert.AreEqual(1, books.Count);
        }
    }
}