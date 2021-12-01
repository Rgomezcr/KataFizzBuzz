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

        [Fact]
        public void ReturnFourAsString()
        {
            var number = 4;
            Assert.Equal("4", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnFiveAsStringBuzz()
        {
            var number = 5;
            Assert.Equal("Buzz", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnSixAsStringFizz()
        {
            var number = 6;
            Assert.Equal("Fizz", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnSevenAsString()
        {
            var number = 7;
            Assert.Equal("7", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnEightAsString()
        {
            var number = 8;
            Assert.Equal("8", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnNineAsStringFizz()
        {
            var number = 9;
            Assert.Equal("Fizz", FizzBuzz.ReturnNumberAsString(number));
        }

        [Fact]
        public void ReturnTenAsStringBuzz()
        {
            var number = 10;
            Assert.Equal("Buzz", FizzBuzz.ReturnNumberAsString(number));
        }
    }
}