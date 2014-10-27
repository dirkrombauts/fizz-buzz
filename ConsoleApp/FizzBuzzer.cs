using System;

namespace FizzBuzz.ConsoleApp
{
  public class FizzBuzzer
  {
    public string Print(int currentNumber)
    {
      if ((currentNumber%3) == 0)
      {
        return "Fizz";
      }
      else if ((currentNumber %5) == 0)
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