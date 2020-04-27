using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookComputesStats()
        {
            // arrage

            var book = new Book(" ");
            book.AddGrade(88.4);
            book.AddGrade(90.6);
            book.AddGrade(75.2);

            // act
            var result = book.GetStatistics();

            // assert

            Xunit.Assert.Equal(90.6, result.High, 1);
            Xunit.Assert.Equal(75.2, result.Low, 1);
            Xunit.Assert.Equal(84.7, result.Average, 1);
        }
    }
}
