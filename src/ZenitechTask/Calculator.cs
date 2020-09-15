using System;
using System.Collections.Generic;
using System.Text;

namespace ZenitechTask
{
    public class Calculator : ICalculator
    {
        private const int MAXIMUM_10_BIT_NUMBER = 1024;
        private const int MAXIMUM_STACK_CAPACITY = 5;
        private Stack<int> _numbers { get; set; }

        public Calculator()
        {
            _numbers = new Stack<int>(MAXIMUM_STACK_CAPACITY);
        }

        public int Add()
        {
            if (_numbers.Count >= 2)
            {
                int first = _numbers.Pop();
                int second = _numbers.Pop();
                int result = Modulo10Bit(first + second);

                _numbers.Push(result);
                return result;
            }
            else throw new Exception($"Stack must contain at least 2 numbers. Current count: {_numbers.Count}.");
        }

        public void Pop()
        {
            if (_numbers.Count > 0)
                _numbers.Pop();
        }

        public void Push(int number)
        {
         
            if(_numbers.Count < MAXIMUM_STACK_CAPACITY)
                _numbers.Push(number);
            else throw new Exception($"Stack has reached its maximum capacity of {MAXIMUM_STACK_CAPACITY}.");
        }

        public int Sub()
        {
            if(_numbers.Count >= 2)
            {
                int first = _numbers.Pop();
                int second = _numbers.Pop();
                int result = Modulo10Bit(first - second);

                return result;
            }
            else throw new Exception($"Stack must contain at least 2 numbers. Current count: {_numbers.Count}.");
        }

        public int StackItemCount() => _numbers.Count;

        //Ensures unsigned "10 bit" stack numbers by calculating modulo of result and maximum 10 bit number
        private int Modulo10Bit(int x) => (x % MAXIMUM_10_BIT_NUMBER + MAXIMUM_10_BIT_NUMBER) % MAXIMUM_10_BIT_NUMBER;
    }
}
