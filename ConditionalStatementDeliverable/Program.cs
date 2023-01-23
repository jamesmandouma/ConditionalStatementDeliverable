/*
Author: James Mandouma
Date: 1/23/2023
Description: C# app to calculate letter grade
*/

using System;

namespace ConditionalStatementDeliverable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300?");
                string expectedGrade = Console.ReadLine();
                
                decimal grade = decimal.Parse(expectedGrade);

                if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade is A.");
                }
                else if (grade < 90 && grade >= 80)
                {
                    Console.WriteLine("Your letter grade is B.");
                }
                else if (grade < 80 && grade >= 70)
                {
                    Console.WriteLine("Your letter grade is C.");
                }
                else if (grade < 70 && grade >= 60)
                {
                    Console.WriteLine("Your letter grade is D.");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your letter grade is F.");
                }
            }   
            catch 
            {
                Console.WriteLine("Enter a number");
            }
        }
    }
}