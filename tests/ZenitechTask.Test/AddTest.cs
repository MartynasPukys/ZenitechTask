using System;
using Xunit;

namespace ZenitechTask.Test
{
    public class AddTest
    {
        [Fact]
        public void AddEmptyStack_Error()
        {
            //Arrange
            ICalculator calculator = new Calculator();

            //Assert
            Assert.Throws<Exception>(() => calculator.Add());
        }

        [Fact]
        public void AddFilledStack_Success()
        {
            //Arrange
            int first = 5;
            int second = 13;

            ICalculator calculator = new Calculator();
            calculator.Push(first);
            calculator.Push(second);

            //Act
            int result = calculator.Add();

            //Assert
            Assert.Equal(first + second, result);
        }
    }
}
