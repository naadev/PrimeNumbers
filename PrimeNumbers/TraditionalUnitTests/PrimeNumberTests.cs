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
            Assert.False(PrimeNumber.IsPrime(8));
        }
        [Fact]
        public void _10_is_not_prime()
        {
            Assert.False(PrimeNumber.IsPrime(8));
        }
        [Fact]
        public void _11_is_prime()
        {
            Assert.True(PrimeNumber.IsPrime(11));
        }
    }
}