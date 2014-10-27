﻿using System;

namespace FizzBuzz.ConsoleApp
{
  public class FizzBuzzer
  {
    public string Print(int currentNumber)
    {
      var isFizzing = (currentNumber%3) == 0;
      var isBuzzing = (currentNumber %5) == 0;

      if (isFizzing && isBuzzing)
      {
        return "FizzBuzz";
      }
      if (isFizzing)
      {
        return "Fizz";
      }
      else if (isBuzzing)
      {
        return "Buzz";
      }
      else
      {
        return currentNumber.ToString();
      }
    }
  }
}