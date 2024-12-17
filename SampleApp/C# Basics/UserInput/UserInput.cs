using System;

namespace SampleApp.C__Basics.UserInput
{
    class UserInputExamples
    {
        // Method to collect user input and display the results.
        public void CollectAndDisplayUserInput()
        {
            // Prompt the user to enter their name.
            Console.WriteLine("Please Enter Your Name");
            string? name = Console.ReadLine();

            // Prompt the user to enter their age.
            Console.WriteLine("Please Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            // Print the user's name and age.
            Console.WriteLine("Your Name is" + " " + name);
            Console.WriteLine("Your Age is " + " " + age);
        }
    }
}
