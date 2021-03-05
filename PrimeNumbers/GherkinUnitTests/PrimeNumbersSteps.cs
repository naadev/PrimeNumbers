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
            IsPrime = PrimeNumber.IsPrime(Number.Value);
        }

        bool? IsPrime { get; set; }
        [When(@"I check whether is prime or not")]
        public void WhenICheckWhetherIsPrimeOrNot()
        {
            IsPrime = (Number.HasValue && IsPrime.HasValue) ? PrimeNumber.IsPrime(Number.Value) : null;
        }
        
        [Then(@"the operation result shall be '(.*)'")]
        public void ThenTheOperationResultShallBe(bool isTrue)
        {
            Assert.NotNull(Number);
            Assert.NotNull(IsPrime);
            Assert.True(isTrue == IsPrime.Value,$"Number {Number.Value} was {(isTrue ? string.Empty : "not")} expected to be prime");
        }
        [Then(@"the number is prime")]
        public void ThenTheNumberIsPrime()
        {
            ThenTheOperationResultShallBe(true);
        }
        [Then(@"the number is not prime")]
        public void ThenTheNumberIsNotPrime()
        {
            ThenTheOperationResultShallBe(false);
        }

    }
}
