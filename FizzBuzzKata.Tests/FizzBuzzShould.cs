using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnOneAsString()
        {
            var number = 1;
            Assert.Equal("1", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnTwoAsString()
        {
            var number = 2;
            Assert.Equal("2", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnThreeAsStringFizz()
        {
            var number = 3;
            Assert.Equal("Fizz", FizzBuzz.ReturnNumberAsString(number));
        } 
        
    }
}