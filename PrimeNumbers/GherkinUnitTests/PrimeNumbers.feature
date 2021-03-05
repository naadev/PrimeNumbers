Feature: PrimeNumbers
	As a SW Developer,
	I want to have an operation
	returning whether a number is prime or not
@PrimeNumbers
Scenario: 02 is prime
   Given a number '2'
   When I check whether is prime or not
   Then the number is prime

@PrimeNumbers
Scenario: 03 is prime
   Given a number '3'
   When I check whether is prime or not
   Then the number is prime

@PrimeNumbers
Scenario: 04 is prime
   Given a number '4'
   When I check whether is prime or not
   Then the number is not prime

@PrimeNumbers
Scenario: 05 is prime
   Given a number '5'
   When I check whether is prime or not
   Then the number is prime

@PrimeNumbers
Scenario: 06 is prime
   Given a number '6'
   When I check whether is prime or not
   Then the number is not prime

@PrimeNumbers
Scenario: 07 is prime
   Given a number '2'
   When I check whether is prime or not
   Then the number is prime

@PrimeNumbers
Scenario: 08 is prime
   Given a number '8'
   When I check whether is prime or not
   Then the number is not prime

@PrimeNumbers
Scenario: 09 is prime
   Given a number '9'
   When I check whether is prime or not
   Then the number is not prime

@PrimeNumbers
Scenario: 10 is prime
   Given a number '10'
   When I check whether is prime or not
   Then the number is not prime

@PrimeNumbers
Scenario: 11 is prime
   Given a number '11'
   When I check whether is prime or not
   Then the number is prime



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
     | 10     | false  |
     | 11     | true   |
