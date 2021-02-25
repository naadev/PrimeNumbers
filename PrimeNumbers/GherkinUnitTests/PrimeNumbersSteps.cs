using System;
using TechTalk.SpecFlow;
using Xunit;

namespace PrimeNumbers.GherkinUnitTests
{
    [Binding]
    public class PrimeNumbersSteps
    {
        int? Number { get; set; }
        [Given(@"a number '(.*)'")]
        public void GivenANumber(int isThatNumberPrime)
        {
            Number = isThatNumberPrime;
        }

        bool? IsPrime { get; set; }
        [When(@"I check whether is prime or not")]
        public void WhenICheckWhetherIsPrimeOrNot()
        {
            if (Number.HasValue)
            {
                IsPrime = PrimeNumber.IsPrime(Number.Value);
            }
        }
        
        [Then(@"the operation result shall be '(.*)'")]
        public void ThenTheOperationResultShallBe(bool isTrue)
        {
            Assert.NotNull(Number);
            Assert.NotNull(IsPrime);
            Assert.True(isTrue == IsPrime.Value,$"Number {Number.Value} was {(isTrue ? string.Empty : "not")} expected to be prime");
        }
    }
}
