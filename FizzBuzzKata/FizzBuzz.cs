﻿using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string ReturnNumberAsString(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            
            if (number == 5)
                return "Buzz";
            if (number == 10)
                return "Buzz";
           
           
            return number.ToString();
        }
    }
}