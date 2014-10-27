﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FizzBuzz.Specification.AutomationLayer
{
  [Binding]
  public class StepDefinitions
  {
    private int currentNumber;

    [Given(@"the current number is '(.*)'")]
    public void GivenTheCurrentNumberIs(int currentNumber)
    {
      this.currentNumber = currentNumber;
    }

    [When(@"I print the number")]
    public void WhenIPrintTheNumber()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"the result is '(.*)'")]
    public void ThenTheResultIs(int p0)
    {
      ScenarioContext.Current.Pending();
    }
  }
}
