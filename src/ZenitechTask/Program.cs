using System;

namespace ZenitechTask
{
    class Program
    {
        private static readonly ICalculator _calculator = new Calculator();

        static void Main()
        {
            Console.WriteLine("Hello! Waiting for your input... Press x to exit.");

            while (true)
            {
                string command = Console.ReadLine();
                string[] arguments = command.Split(' ');

                if (arguments.Length == 0)
                {
                    Console.WriteLine("No command specified.");
                    continue;
                }

                string action = arguments[0];
                int value = arguments.Length == 2 ? int.Parse(arguments[1]) : -1;
                ProcessCommand(action, value);
            }
        }

        private static void ProcessCommand(string action, int value)
        {
            int result;
            switch (action)
            {
                case "Add":
                    result = _calculator.Add();
                    Console.WriteLine(">> " + result);
                    break;
                case "Push":
                    _calculator.Push(value);
                    break;
                case "Pop":
                    _calculator.Pop();
                    break;
                case "Sub":
                    result = _calculator.Sub();
                    Console.WriteLine(">> " + result);
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unindentified command.");
                    break;
            }
        }
    }
}
