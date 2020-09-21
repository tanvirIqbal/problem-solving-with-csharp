using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvingWithCSharp
{
    public class BasicProblem
    {
        public static void AddAndMultiply()
        {
            /*
             * Given three numbers, write a method that adds two first ones and multiplies them by a third one.
             */
            int firstNumber, secondNumber, thirdNumber;
            bool success1, success2, success3;
            Console.WriteLine("Enter First Number");
            success1 = Int32.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter Second Number");
            success2 = Int32.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine("Enter Third Number");
            success3 = Int32.TryParse(Console.ReadLine(), out thirdNumber);

            if (!success1 || !success2 || !success3)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            Console.WriteLine("Result: " + (firstNumber + secondNumber) * thirdNumber);
        }
    }
}
