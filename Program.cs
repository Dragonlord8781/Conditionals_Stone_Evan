using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for a whole number
            Console.WriteLine("Please enter a whole number, and we'll see if its postive or negative, even or odd");
            //declares firstNum and assigns it the inputted whole number
            int firstNum = Convert.ToInt32(Console.ReadLine());
            //declares posNeg and have it determine true if firstNum is greater than 0 and false if firstNum is less than 0
            bool posNeg = firstNum > 0;
            //if posNeg is true writes a line stating that firstNum is a postive number
            if (posNeg == true)
                 {
                      Console.WriteLine($"{firstNum} is postive");
                 }
                 //otherwise if posNeg is false it writes a line stating that firstNum is a negative number
            else if (posNeg == false) 
                 {
                     Console.WriteLine($"{firstNum} is negative");
                 }

            //writes a line saying "and" to both seperate the two if-else sections and to connect them as effecting the same input
            Console.WriteLine("and");
            //detemines if firstNum is % 2 == 0 then write a statement saying its even, otherwise write a statement saying its odd
            if (firstNum % 2 == 0) 
                 {
                      Console.WriteLine($"{firstNum} is even");
                 }
            else
                 { 
                      Console.WriteLine($"{firstNum} is odd");
                 }

            //asks for a second whole number
            Console.WriteLine("Please enter a second whole number");
            //declares secNum and assigns the inputted number
            int secNum = Convert.ToInt32(Console.ReadLine());
            //asks for a third whole number
            Console.WriteLine("Now please enter a third whole number");
            //declares triNum and assigns the inputted number
            int triNum = Convert.ToInt32(Console.ReadLine());
            //states its comparing the three numbers
            Console.WriteLine("Comparing...");
            //declares largest and assignes the largest int out of firstNum, secNum, and triNum by compairing firstNum to the larger int of secNum or triNum
            int largest = Math.Max(firstNum, Math.Max(secNum, triNum));
            //writes a line saying largest is the largest number
            Console.WriteLine($"{largest} is the largest number");

            //writes a line transtioning from the previous situations to grade part of the project
            Console.WriteLine("Now let's try one last experiment, please input a number grade");
            //declaring grade and assigning the inputted double to it
            double grade = Convert.ToDouble(Console.ReadLine());
            // creates a switch based on grade that outputs a written line like "A: Superior" or "C:Average" depending on the value of grade
            switch (grade)
            {
                case >= 90:
                    Console.WriteLine("A: Superior");
                    break;
                case >= 80:
                    Console.WriteLine("B: Very Good");
                    break;
                case >= 70:
                    Console.WriteLine("C: Average");
                    break; 
                case >= 60:
                    Console.WriteLine("D: Below Average");
                    break;
                case <= 59:
                    Console.WriteLine("F: Fail");
                    break;
            }
        }
    }
}