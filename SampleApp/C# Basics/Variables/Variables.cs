using System;


namespace SampleApp.C__Basics.Variables
{
    class VariableExamples
    {
        // Demonstrates different types of variables and their usage.

        public void DisplayVariableValues()
        {
            // Declare and initialize different types of variables.
            int age = 25;
            double points = 99.9;
            char initial = 'A';
            string firstName = "Sai";
            string lastName = "Srinivas";
            string fullName = firstName + " " + lastName;
            bool isSuccessful = true;

            // Print the values of the variables.
            Console.WriteLine(age);
            Console.WriteLine(points);
            Console.WriteLine(initial);
            Console.WriteLine(fullName);
            Console.WriteLine(isSuccessful);
        }
    }
}
