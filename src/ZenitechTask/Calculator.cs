using System;
using System.Collections.Generic;

namespace ZenitechTask
{
    /*I was thinking of ushort variables everywhere as they are closest to 10 bit unsigned integers specified in requirements.
    But additional casting of calculations seemed adding more complexity to whole than ushorts being beneficial.*/
    public class Calculator : ICalculator
    {
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
            else throw new Exception($"Stack must contain at least 2 values. Current count: {_numbers.Count}.");
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
            else throw new Exception($"Stack must contain at least 2 values. Current count: {_numbers.Count}.");
        }

        public int StackValueCount() => _numbers.Count;

        // Ensures unsigned "10 bit" stack numbers by calculating modulo of result and maximum 10 bit number (1024)
        private int Modulo10Bit(int x) => (x % 1024 + 1024) % 1024;
    }
}
