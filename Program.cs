using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            int firstNum = Console.ReadLine();
            bool posNeg = firstNum > 0;
            if (posNeg == true)
            {
                Console.WriteLine($"{firstNum} is a postive number");
            }
            else if (posNeg == false) 
            {
                Console.WriteLine($"{firstNum} is a negative number");
            }
        }
    }
}