using System;
using Xunit;

namespace ZenitechTask.Test
{
    public class SubTest
    {
        [Fact]
        public void SubFilledStack_Success()
        {
            //Arrange
            int secondTopmost = 17;
            int topmost = 25;

            ICalculator calculator = new Calculator();
            calculator.Push(secondTopmost);
            calculator.Push(topmost);

            //Act
            int result = calculator.Sub();

            //Assert
            Assert.Equal(topmost - secondTopmost, result);
        }

        [Fact]
        public void SubEmptyStack_Error()
        {
            //Arrange
            ICalculator calculator = new Calculator();

            //Assert
            Assert.Throws<Exception>(() => calculator.Sub());
        }
    }
}
