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
     | 10     | false  |
     | 11     | true   |
