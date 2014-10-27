using System;

namespace FizzBuzz.ConsoleApp
{
  class Program
  {
    static void Main()
    {
      var fizzBuzzer = new FizzBuzzer();

      for (int i = 1; i <= 100; i++)
      {
        Console.WriteLine(fizzBuzzer.Print(i));
      }
    }
  }
}
