using Xunit;

namespace ZenitechTask.Test
{
    public class PopTest
    {
        [Fact]
        public void PopEmptyStack_NoError()
        {
            //Arrange
            ICalculator calculator = new Calculator();

            //Act
            calculator.Pop();

            //Assert
            Assert.Equal(0, calculator.StackValueCount());
        }

        [Fact]
        public void PopFilledStack_Success()
        {
            //Arrange
            ICalculator calculator = new Calculator();
            calculator.Push(1);

            //Act
            calculator.Pop();

            //Assert
            Assert.Equal(0, calculator.StackValueCount());
        }
    }
}
