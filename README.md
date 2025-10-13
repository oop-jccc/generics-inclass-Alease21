# In-Class Programming Assignment: Overloading Methods

## Objective
Extend the existing `Multiply` method in the `OverloadingTests` class to support multiplication of three parameters of the same type. Also, create an NUnit test to validate that your new method works as expected.

## Starter Code
You will be provided with the starter code that contains the `Multiply` method for two parameters of the same type and one for two parameters of different types, as well as their respective tests.

## Instructions

### Step 1: Add a New Multiply Method
1. In the `OverloadingTests` class, add a new `Multiply` method.
2. This new method should take three parameters of the same generic type `T`.
3. Add a constraint to ensure that `T` implements `IConvertible`.
4. Inside the method, use the `dynamic` keyword to perform the multiplication of the three parameters.

### Step 2: Implement the Test
1. Below the existing tests, add a new test method.
2. This test should call the new `Multiply` method that you created with three parameters.
3. Use the `Assert.That` method to validate that the result is as expected.

### Step 3: Run the Test
1. After implementing the method and the test, run all tests to ensure that they pass.