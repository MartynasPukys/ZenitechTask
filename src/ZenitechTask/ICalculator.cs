using System;
using System.Collections.Generic;
using System.Text;

namespace ZenitechTask
{
    public interface ICalculator
    {
        /// <summary>
        /// Pushes value on the memory stack.
        /// </summary>
        void Push(int number);

        /// <summary>
        /// Pops a value from the memory stack and discards it.
        /// </summary>
        void Pop();

        /// <summary>
        /// Pops two values from the stack, adds them together.
        /// </summary>
        int Add();

        /// <summary>
        /// Pops two values from the stack, subtracts the second topmost from the topmost.
        /// </summary>
        int Sub();

        /// <summary>
        /// Returns stack value count
        /// </summary>
        /// <remarks>Used in unit tests</remarks>
        int StackValueCount();
    }
}
