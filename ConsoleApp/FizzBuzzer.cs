using System;
using System.Globalization;

namespace FizzBuzz.ConsoleApp
{
  public class FizzBuzzer
  {
    public string Print(int currentNumber)
    {
      var isFizzing = (currentNumber%3) == 0;
      var isBuzzing = (currentNumber%5) == 0;

      if (isFizzing && isBuzzing)
      {
        return "FizzBuzz";
      }
      else if (isFizzing)
      {
        return "Fizz";
      }
      else if (isBuzzing)
      {
        return "Buzz";
      }
      else
      {
        return currentNumber.ToString(CultureInfo.CurrentCulture);
      }
    }
  }
}