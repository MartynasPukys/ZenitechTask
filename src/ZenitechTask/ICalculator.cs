using System;
using System.Collections.Generic;
using System.Text;

namespace ZenitechTask
{
    public interface ICalculator
    {
        void Push(int number);
        void Pop();
        int Add();
        int Sub();
        int StackItemCount();
    }
}
