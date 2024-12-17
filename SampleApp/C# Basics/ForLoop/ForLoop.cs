using System;

namespace SampleApp.C__Basics.Loops
{
    class ForLoopExamples
    {
        // Demonstrates a for loop with a continue statement.
        public void DisplayNumbersSkippingFive()
        {
            // Loop from 1 to 9, skipping 5.
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        // Demonstrates a for loop that prints even numbers.
        public void DisplayEvenNumbers()
        {
            // Loop to print even numbers between 2 and 16.
            for (int i = 2; i < 16; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
