# PrimeNumbers
Comparisson between Unit Tests using Specflow (BDD tool) &amp; xUnit traditional unit testing

This repository hosts a demo intended to compare how to execute Test Driven Development following two different approaches:

1) Name of approach 1
2) Name of approach 2

## Composition
This project has been built on C# (.NET 5)  using Visual Studio, hence the solution file (.sln). 

There is only a single project, inside folder PrimeNumbers. Users using Visual Studio Code or other IDE can start from here

* [PrimeNumber.cs ](https://github.com/naadev/PrimeNumbers/blob/main/PrimeNumbers/PrimeNumber.cs)
This is a static class with a single operation. Commented there appear the different steps given during test development. 

```C#
        static public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
```
### [Gherkin Unit Tests folder](https://github.com/naadev/PrimeNumbers/tree/main/PrimeNumbers/GherkinUnitTests)
These are the Unit Tests created using Gherkin.
.* [PrimeNumbers.feature](https://github.com/naadev/PrimeNumbers/blob/main/PrimeNumbers/GherkinUnitTests/PrimeNumbers.feature)
This is the feature file. 
```Gherkin
Feature: PrimeNumbers
	As a SW Developer,
	I want to have an operation
	returning whether a number is prime or not

@PrimeNumbers
Scenario Outline: Detecting a number is prime
	Given a number '<number>'
	When I check whether is prime or not
	Then the operation result shall be '<result>'
Examples: 
     | number | result |
     | 02     | true   |
     | 03     | true   |
     | 04     | false  |
     | 05     | true   |
```

New tests can be created by adding a single line:
```Gherkin
  Feature: PrimeNumbers
	As a SW Developer,
	I want to have an operation
	returning whether a number is prime or not

@PrimeNumbers
Scenario Outline: Detecting a number is prime
	Given a number '<number>'
	When I check whether is prime or not
	Then the operation result shall be '<result>'
Examples: 
     | number | result |
     | 02     | true   |
     | 03     | true   |
     | 04     | false  |
     | 05     | true   |
     | 06     | false  |
     | 07     | true   |
     | 08     | false  |
     | 09     | false  |
Feature: PrimeNumbers
	As a SW Developer,
	I want to have an operation
	returning whether a number is prime or not

@PrimeNumbers
Scenario Outline: Detecting a number is prime
	Given a number '<number>'
	When I check whether is prime or not
	Then the operation result shall be '<result>'
Examples: 
     | number | result |
     | 02     | true   |
     | 03     | true   |
     | 04     | false  |
     | 05     | true   |
     | 06     | false  |
```

.* [PrimeNumberSteps.cs](https://github.com/naadev/PrimeNumbers/blob/main/PrimeNumbers/GherkinUnitTests/PrimeNumberSteps.cs)
These is the steps file. Here we link Gherkin steps with specific technology. In this case we are working on C# hence we use Specflow to support Gherkin syntax and step binding

#### [Traditional Unit Test ](https://github.com/naadev/PrimeNumbers/tree/main/PrimeNumbers/TraditionalUnitTests)
.* [PrimeNumberTests.cs](https://github.com/naadev/PrimeNumbers/blob/main/PrimeNumbers/TraditionalUnitTests/PrimeNumberTests.cs)
This file  describes the same Unit Tests for TDD but created using a traditional way. 

In this case, in order to build a new test, we need to add a C# block. In this example, the name of the tests is self-descriptive:
```C#
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
```
We can add new tests by copy&paste and modify the code
```C#
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
```
