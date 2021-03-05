using System;
using Xunit;

namespace PrimeNumbers
{
    public class PrimeNumberTests
    {
        [Fact]
        public void _02_is_prime()
        {
            Assert.True(PrimeNumber.IsPrime(2));
        }
        [Fact]
        public void _03_is_prime()
        {
            Assert.True(PrimeNumber.IsPrime(3));
        }
        [Fact]
        public void _04_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(4));
        }
        [Fact]
        public void _05_is_prime()
        {
            Assert.True(PrimeNumber.IsPrime(5));
        }
        [Fact]
        public void _06_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(6));
        }
        [Fact]
        public void _07_is_not_prime()
        {
            Assert.True(PrimeNumber.IsPrime(7));
        }
        [Fact]
        public void _08_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(8));
        }
        [Fact]
        public void _09_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(9));
        }
        [Fact]
        public void _10_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(10));
        }
        [Fact]
        public void _11_is_prime()
        {
            Assert.True(PrimeNumber.IsPrime(11));
        }
        [Fact]
        public void _12_is_prime()
        {
            Assert.False(PrimeNumber.IsPrime(12));
        }
        [Theory]
        [InlineData(02, true)]
        [InlineData(03, true)]
        [InlineData(04, false)]
        [InlineData(05, true)]
        [InlineData(06, false)]
        [InlineData(07, true)]
        [InlineData(08, false)]
        [InlineData(09, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void IsThisAPrimeNumber(int number, bool result)
        {
            Assert.True(result == PrimeNumber.IsPrime(number));
        }
    }
}
