using System;

namespace SampleApp.C__Basics.SwitchCase
{
    class NumberSelectorClass
    {
        public void SelectNumber()
        {
            // Prompt the user to enter a number between 1 and 5.
            Console.WriteLine("Enter a number between 1 and 5:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Use a switch statement to handle different cases based on the input.
            switch (number)
            {
                case 1:
                    Console.WriteLine("You selected One.");
                    break;

                case 2:
                    Console.WriteLine("You selected Two.");
                    break;

                case 3:
                    Console.WriteLine("You selected Three.");
                    break;

                case 4:
                    Console.WriteLine("You selected Four.");
                    break;

                case 5:
                    Console.WriteLine("You selected Five.");
                    break;

                // Handle invalid inputs outside the range 1 to 5.
                default:
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
