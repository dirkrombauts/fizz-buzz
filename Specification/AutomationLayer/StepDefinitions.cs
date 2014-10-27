using System;
using FizzBuzz.ConsoleApp;
using NFluent;
using TechTalk.SpecFlow;

namespace FizzBuzz.Specification.AutomationLayer
{
  [Binding]
  public class StepDefinitions
  {
    private int currentNumber;
    private string currentResult;

    [Given(@"the current number is '(.*)'")]
    public void GivenTheCurrentNumberIs(int currentNumber)
    {
      this.currentNumber = currentNumber;
    }

    [When(@"I print the number")]
    public void WhenIPrintTheNumber()
    {
      this.currentResult = new FizzBuzzer().Print(this.currentNumber);
    }

    [Then(@"the result is '(.*)'")]
    public void ThenTheResultIs(string expectedResult)
    {
      Check.That(this.currentResult).IsEqualTo(expectedResult);
    }
  }
}
