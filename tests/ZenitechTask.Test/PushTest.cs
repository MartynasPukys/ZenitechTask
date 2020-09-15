using System;
using Xunit;

namespace ZenitechTask.Test
{
    public class PushTest
    {
        [Fact]
        public void ExceedStackCapacity_Error()
        {
            //Arrange
            ICalculator calculator = new Calculator();
            calculator.Push(2);
            calculator.Push(2);
            calculator.Push(2);
            calculator.Push(2);
            calculator.Push(2);

            //Assert
            Assert.Throws<Exception>(() => calculator.Push(2));
        }

        [Fact]
        public void PushNumber_Success()
        {
            //Arrange
            ICalculator calculator = new Calculator();

            //Act
            calculator.Push(2);

            //Assert
            Assert.Equal(1, calculator.StackValueCount());
        }
    }
}
