using System;

namespace SecondMethodAssin
{
    class Program
    {
        static void Main(string[] args)
        {
            twoMeths math = new twoMeths();
            int userNum;
            Console.WriteLine("Input two numbers, one at a time. You don't need to enter anything for the second number");
            userNum = Convert.ToInt32(Console.ReadLine());
            math.OptionMath(userNum);
            Console.WriteLine(math.OptionMath(userNum));
        }
    }
}
