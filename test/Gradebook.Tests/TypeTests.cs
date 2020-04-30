using System;
using Xunit;

namespace Gradebook.Tests
{
    public delegate string WriteLogDelegate(string LogMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            // arrage
            WriteLogDelegate log = ReturnMessage;

            log += new WriteLogDelegate(ReturnMessage);
            log += new WriteLogDelegate(IncrementMessage);

            // log = ReturnMessage;

            var result = log("Hello");

            // assert
            Xunit.Assert.Equal(3, count);

        }

        string IncrementMessage(string Message)
        {
            count += 1;
            return Message.ToLower();
        }

        string ReturnMessage(string Message)
        {
            count += 1;
            return Message;
        }

        [Fact]
        public void CsharpCanPassValueByRef()
        {
            // arrage

            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // assert

            Xunit.Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CsharpIsByValue()
        {
            // arrage

            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // assert

            Xunit.Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

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
