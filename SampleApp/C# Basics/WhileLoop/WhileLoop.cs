using System;

namespace SampleApp.C__Basics.Loops
{
    public class WhileLoopExamples
    {
        // Demonstrates a simple while loop.
        public void DisplayNumbersUpToTen()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Print the current value of i.
                Console.WriteLine(i);

                // Increment i.
                i++;
            }
        }

        // Demonstrates a while loop with a break statement.
        public void DisplayNumbersWithBreak()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Exit the loop when i equals 6.
                if (i == 6)
                {
                    break;
                }

                Console.WriteLine(i);

                i++;
            }
        }

        // Demonstrates a while loop with a continue statement.
        public void DisplayNumbersWithContinue()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Skip the rest of the loop when i equals 6.
                if (i == 6)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);

                i++;
            }
        }
    }
}
