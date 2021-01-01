using System;

namespace SecondMethodAssin
{
    class Program
    {
        static void Main(string[] args)
        {
            twoMeths math = new twoMeths();
            int userNum;
            string userNum2;
            Console.WriteLine("Input two numbers, one at a time.");
            userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You don't have to input a second number, up to you.");
            userNum2 = Console.ReadLine();
            if(userNum2 == "")
            {
                math.OptionMath(userNum);
                Console.WriteLine(math.OptionMath(userNum));
            }
            else
            {
                int result;
                result = Convert.ToInt32(userNum2);
                math.OptionMath(result);
                Console.WriteLine(math.OptionMath(result));
            }
        }
    }
}
