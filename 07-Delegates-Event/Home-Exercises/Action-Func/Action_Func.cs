using System;

namespace Action_Func
{
    class Action_Func
    {
        static void Main(string[] args)
        {
            Func<string, int> intParseFunction = int.Parse;
            int num = intParseFunction("10");

            Action<int> printNumberAction = Console.WriteLine;
            printNumberAction(num);
        }
    }
}
