using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.UserInput
{
    class UserInputClass
    {
        // User Input.

        public void UserInputMethod()
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
