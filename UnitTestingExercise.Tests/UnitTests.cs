using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(6, 8, 7, 21)]
        [InlineData(1, 9, 0, 10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var adder = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = adder.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,11,-5)]//Add test data <-------
        [InlineData(6,3,3)]
        [InlineData(9,7,2)]
        [InlineData(2,5,-3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractor = new Calculator();

            //Act
            var actual = subtractor.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 11, 66)]//Add test data <-------
        [InlineData(6, 3, 18)]
        [InlineData(9, 7, 63)]
        [InlineData(2, 5, 10)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multip = new Calculator();
            //Act
            var actual = multip.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(48, 3, 16)]//Add test data <-------
        [InlineData(6, 3, 2)]
        [InlineData(21, 7, 3)]
        [InlineData(10, 5, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divider = new Calculator();
            //Act
            var actual = divider.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
