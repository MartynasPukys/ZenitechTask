using System;
using System.Collections.Generic;
using System.Text;

namespace ZenitechTask
{
    interface ICalculator
    {
        void Push(int number);
        void Pop();
        int Add();
        int Sub();
    }
}
