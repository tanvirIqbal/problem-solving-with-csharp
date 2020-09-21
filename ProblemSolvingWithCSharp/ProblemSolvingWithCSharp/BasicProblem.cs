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

        public static void CelsiusToFahrenheit()
        {
            /*
                Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!
                Expected input and output 
                CtoF(0) → "T = 32F"
                CtoF(100) → "T = 212F"
                CtoF(-300) → "Temperature below absolute zero!"
             */
            double celsiusValue, fahrenheitValue;
            bool success1;
            Console.WriteLine("Enter Celsius Value");
            success1 = Double.TryParse(Console.ReadLine(), out celsiusValue);

            if (!success1)
            {
                Console.WriteLine("You have entered invalid value.");
                return;
            }
            fahrenheitValue = celsiusValue * 1.8 + 32;
            if (fahrenheitValue < -271.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }
            else
            {
                Console.WriteLine("T = " + fahrenheitValue + "F");
            }
        }
    }
}
