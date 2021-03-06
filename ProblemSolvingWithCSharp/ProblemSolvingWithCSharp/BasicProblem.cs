﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvingWithCSharp
{
    public class BasicProblem
    {
        #region Basic Problems
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
        public static void ElementaryOperations()
        {
            /*
             *  Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!
                Expected input and output 
                ElementaryOperations(3, 8) → 11, -5, 24, 0.375
             */
            double addition, substraction, multiplication;
            double division;
            bool success1, success2;
            Console.WriteLine("Enter a");
            success1 = Double.TryParse(Console.ReadLine(), out double firstNumber);
            Console.WriteLine("Enter b");
            success2 = Double.TryParse(Console.ReadLine(), out double secondNumber);
            addition = firstNumber + secondNumber;
            substraction = firstNumber - secondNumber;
            multiplication = firstNumber * secondNumber;
            division = secondNumber != 0 ? firstNumber / secondNumber : 0;
            if (!success1 || !success2)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            Console.WriteLine(String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}"));
        }
        public static void ModuloOperations()
        {
            /*
             *  Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
                Expected input and output 
                ModuloOperations(8, 5, 2) → 1
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
            Console.WriteLine("Result: " + firstNumber % secondNumber % thirdNumber);
        }
        public static void TheCubeOf()
        {
            /*
             *  Given a number, write a method that returns its cube.  
                Expected input and output  
                TheCubeOf(2) → 8  
                TheCubeOf(-5.5) → -166.375  
             */
            bool success1;
            Console.WriteLine("Enter a Number");
            success1 = Double.TryParse(Console.ReadLine(), out double firstNumber);

            if (!success1)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            Console.WriteLine("Result: " + firstNumber * firstNumber * firstNumber);
        }
        public static void SwapTwoNumbers()
        {
            /*
             *  Given two integers, write a method that swaps them using temporary variable.
                Expected input and output 
                SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
                SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"
             */
            int tempNumber;
            bool success1, success2;
            Console.WriteLine("Enter a");
            success1 = Int32.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter b");
            success2 = Int32.TryParse(Console.ReadLine(), out int secondNumber);
            string before = $"Before: a = {firstNumber}, b = {secondNumber}; ";
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
            string after = $"After: a = {firstNumber}, b = {secondNumber}; ";
            if (!success1 || !success2)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            Console.WriteLine(before + after);
        }
        #endregion

        public static void AbsoluteValue()
        {
            /*
             *  Given an integer, write a method that returns its absolute value.
                Expected input and output 
                AbsoluteValue(6832) → 6832
                AbsoluteValue(-392) → 392  
             */
            bool success1;
            Console.WriteLine("Enter a Number");
            success1 = Double.TryParse(Console.ReadLine(), out double firstNumber);

            if (!success1)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            //Console.WriteLine("Result: " + (firstNumber >= 0 ? firstNumber : firstNumber*-1));
            Console.WriteLine("Result: " + Math.Abs(firstNumber));
        }
        public static void DivisibleBy2Or3()
        {
            /*
             *  Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
                Expected input and output 
                DivisibleBy2Or3(15, 30) → 450
                DivisibleBy2Or3(2, 90) → 180
                DivisibleBy2Or3(7, 12) → 19
             */
            bool success1, success2;
            Console.WriteLine("Enter a");
            success1 = Int32.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter b");
            success2 = Int32.TryParse(Console.ReadLine(), out int secondNumber);
            if (!success1 || !success2)
            {
                Console.WriteLine("You have entered invalid number.");
                return;
            }
            Console.WriteLine(((firstNumber % 2 == 0 && secondNumber % 2 == 0) || (firstNumber % 3 == 0 && secondNumber % 3 == 0)) ? firstNumber * secondNumber : firstNumber + secondNumber);
        }
    }
}
