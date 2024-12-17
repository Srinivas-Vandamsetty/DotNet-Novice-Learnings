using System;

namespace SampleApp.C__Basics.IfElse
{
    class conditionalLogic
    {
        // Method to determine and display age category based on user input.
        public void DetermineAgeCategory()
        {
            // Ask the user to enter their age.
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the age is less than 18.
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            // Check if the age is between 18 and 60.
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("You are an adult.");
            }
            // Age is 60 or above.
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
    }
}
