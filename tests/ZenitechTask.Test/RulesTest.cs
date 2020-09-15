using Xunit;

namespace ZenitechTask.Test
{
    public class RulesTest
    {
        [Theory]
        [InlineData(1030, 2)] //Overflow higher than range
        [InlineData(5, 7)] //Overflow lower than range
        public void ResultCantOverflow(int topMost, int secondTopMost)
        {
            //Arrange
            ICalculator calculator = new Calculator();
            calculator.Push(secondTopMost);
            calculator.Push(topMost);

            //Act
            int result = calculator.Sub();

            //Assert
            Assert.True(result >= 0 && result < 1024);
        }
    }
}
