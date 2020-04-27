using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrage

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act

            // assert
            Xunit.Assert.Equal("Book 1", book1.Name);
            Xunit.Assert.Equal("Book 2", book2.Name);

        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
