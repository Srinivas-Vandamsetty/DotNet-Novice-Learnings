using System;

namespace SampleApp.C__Basics.Arrays
{
    // Class to demonstrate single-dimensional arrays.
    class SingleDimensionalArrayExamples
    {
        public void DisplayArrayElementAtIndexThree()
        {
            // Initialize an array with a fixed size.
            int[] evenNumbers = new int[5];

            Console.WriteLine(evenNumbers[3]);
        }

        public void DisplayElementAtIndexThree()
        {
            // Declare and initialize an array.
            int[] oddNumbers = { 1, 3, 5, 7, 9 };

            Console.WriteLine(oddNumbers[3]);
        }

        public void ModifyAndDisplayArrayElement()
        {
            // Modify the third element of the array.
            string[] bikes = { "Enfield", "Yamaha", "Bajaj", "Honda" };
            bikes[2] = "Hero";

            Console.WriteLine(bikes[2]);
        }

        public void DisplayArrayElementsWithIndex()
        {
            // Declare and initialize a single-dimensional array.
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Loop through the array elements and print each with its index.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }
        }
    }
}
