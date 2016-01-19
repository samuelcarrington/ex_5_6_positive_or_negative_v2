using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_6_positive_or_negative_v2
{
    class Program
    {
        static void Main()
        {
            /*5-6	Positive or Negative? 
            One thing that a lot people have trouble with is doing multiplication when negative numbers 
            are involved. They typically run into trouble when trying to figure out if the result should 
            be positive or negative. You're going to write a program to help them! But there's a catch. 
            In this example, you're banned from actually doing the multiplication to figure out the answer. 
            (it would be all too easy to take two numbers and multiply them, and then check if the result 
            is greater than or less than zero.) Instead, you will follow the same logic that a human has 
            to follow to get your answer. When you're multiplying two numbers together, 
            if the two numbers have the same sign (both positive or both negative) the result is positive. 
            If they have different signs, the result is negative. 
            
            Write a program that asks the user for two numbers and then, using the rule above, 
            prints out whether the result should be positive or negative.
            */

            Console.WriteLine("Enter two numbers to be told if the result when they are multiplied will be Positive or Negative.");
            Console.Write("Enter the first number:  ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:  ");
            int secondNumber = int.Parse(Console.ReadLine());
            if (((firstNumber > 0) && (secondNumber > 0)) || ((firstNumber < 0) && (secondNumber < 0)))
            {
                Console.WriteLine("The result is positive.");
            }
            else
            { 
                if (((firstNumber < 0) && (secondNumber > 0)) || ((firstNumber > 0) && (secondNumber < 0)))
                {
                    Console.WriteLine("The result is negative.");
                }
                else
                {
                    Console.WriteLine("The result zero is neither positive nor negative.");
                }
            }
            Console.ReadKey();
        }
    }
}
