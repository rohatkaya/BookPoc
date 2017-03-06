using BookPoc.Domain.Tests.Base;
using NUnit.Framework;

namespace BookPoc.Domain.Tests.Application.BusinessUseCases
{
    public class AddAuthorTest : TestBase
    {
        [Test]
        public void AddAuthor_Successfully()
        {
            var added = BookAppService.AddAuthor.Add("test");
            Assert.IsTrue(added);
        }
    }
}