using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1: Base Assignment Class
            Assignment baseAssignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(baseAssignment.GetSummary());
            Console.WriteLine();

            // Test 2: MathAssignment Class
            MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());
            Console.WriteLine();

            // Test 3: WritingAssignment Class
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }
}