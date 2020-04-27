using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference()
        {
            // arrage

            var book1 = GetBook("Book 1");
            setName(book1, "New Name");

            // assert

            Xunit.Assert.Equal("New Name", book1.Name);

        }

        private void setName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrage

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Xunit.Assert.Equal("Book 1", book1.Name);
            Xunit.Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObjects()
        {
            // arrage

            var book1 = GetBook("Book 1");
            var book2 = book1;

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
