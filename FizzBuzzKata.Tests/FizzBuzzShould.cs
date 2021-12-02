using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(20, "Buzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void ReturnNumberAsString(int number, string numberAsString)
        {
            Assert.Equal(numberAsString, FizzBuzz.ReturnNumberAsString(number));
        } 
        
    }
}