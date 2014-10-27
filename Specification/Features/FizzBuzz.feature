Feature: FizzBuzz
  In order to improve mental agility
  I want to replace some numbers in a sequence with the words "fizz" and "buzz"

  The program prints the numbers from 1 to 100.
  But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
  For numbers which are multiples of both three and five print "FizzBuzz".


  Scenario: Regular numbers are printed as they are
    
    This example uses number seven since it is the next prime number after 5,
    and thus self-evidently should result in neither "Fizz" nor "Buzz".
    
    Given the current number is '7'
    When I print the number
    Then the result is '7'


  Scenario: Multiples of Three are printed as "Fizz"
    
    This example uses number 9 which is a multiple of 3.
    
    Given the current number is '9'
    When I print the number
    Then the result is 'Fizz'


  Scenario: Multiples of Five are printed as "Buzz"
    
    This example uses number 10 which is a multiple of 5.
    
    Given the current number is '10'
    When I print the number
    Then the result is 'Buzz'


  Scenario: Multiples of both Three and Five are printed as "FizzBuzz"

    This example uses number 15 which is a multiple of 3 and of 5.
    
    Given the current number is '15'
    When I print the number
    Then the result is 'FizzBuzz'
