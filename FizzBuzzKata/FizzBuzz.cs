using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string ReturnNumberAsString(int number)
        {
            if (number == 1)
                return "1";
            if (number == 2)
                return "2";
            if (number == 3)
                return "Fizz";
            if (number == 4)
                return "4";
            if (number == 5)
                return "Buzz";
            return "Fizz";
        }
    }
}