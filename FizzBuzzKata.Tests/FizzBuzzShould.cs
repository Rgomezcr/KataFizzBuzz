using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnOneAsString()
        {
            Assert.Equal("1", FizzBuzz.ReturnNumberAsString());
        }
    }
}