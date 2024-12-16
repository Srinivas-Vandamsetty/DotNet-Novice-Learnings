using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.IfElse
{
    class IfElseClass
    {
        public void IfElseMethod()
        {
            // Ask the user to enter their age.
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the age is less than 18.
            if (age < 18)
            {
                Console.WriteLine("You are minor");
            }
            // Check if the age is between 18 and 60.
            else if (age > 18 && age < 60)
            {
                Console.WriteLine("You are major");
            }
            // Age is 60 or above.
            else
            {
                Console.WriteLine("You are senior citizen");
            }
        }
    }
}
