using System;

namespace SampleApp.C__Basics.Operators
{
    class OperatorsExamples
    {
        public void DisplayOperators()
        {
            // Assignment operator (=).
            int i = 777;
            Console.WriteLine("Assignment: i = {0}", i);

            // Arithmetic operators (+, -, *, /, %).
            int a = 10;
            int b = 20;
            Console.WriteLine("Arithmetic (Addition): a + b = {0}", a + b);
            Console.WriteLine("Arithmetic (Subtraction): a - b = {0}", a - b);
            Console.WriteLine("Arithmetic (Multiplication): a * b = {0}", a * b);
            Console.WriteLine("Arithmetic (Division): b / a = {0}", b / a);
            Console.WriteLine("Arithmetic (Modulus): b % a = {0}", b % a);

            // Relational operators (==, !=, >, <, >=, <=).
            Console.WriteLine("Relational (Equality): a == b = {0}", a == b);
            Console.WriteLine("Relational (Not Equal): a != b = {0}", a != b);
            Console.WriteLine("Relational (Greater Than): a > b = {0}", a > b);
            Console.WriteLine("Relational (Less Than): a < b = {0}", a < b);
            Console.WriteLine("Relational (Greater Than or Equal To): a >= b = {0}", a >= b);
            Console.WriteLine("Relational (Less Than or Equal To): a <= b = {0}", a <= b);

            // Logical operators (&&, ||, !).
            bool condition1 = true;
            bool condition2 = false;
            Console.WriteLine("Logical (AND): condition1 && condition2 = {0}", condition1 && condition2);
            Console.WriteLine("Logical (OR): condition1 || condition2 = {0}", condition1 || condition2);
            Console.WriteLine("Logical (NOT): !condition1 = {0}", !condition1);

            // Increment and Decrement operators (++, --).
            int count = 5;
            Console.WriteLine("Increment: count++ = {0}", count++);
            Console.WriteLine("Decrement: --count = {0}", --count);

            // Conditional (Ternary) operator (? :).
            int max = (a > b) ? a : b;
            Console.WriteLine("Ternary (Conditional): Max of a and b is {0}", max);

        }
    }
}
