using System;

namespace SampleApp.C__Basics.Arrays
{
    class ArraySortingExamples
    {
        // Method to sort and display arrays.
        public void DisplaySortedArrays()
        {
            // Initialize a string array.
            string[] names = { "Sai", "Rajesh", "Akash", "Nagendra", "Praveen" };

            // Sort the string array in ascending order.
            Array.Sort(names);

            Console.WriteLine("Sorted Names:");
            foreach (string name in names)
                Console.WriteLine(name);

            // Initialize an integer array.
            int[] numbers = { 5, 6, 7, 2, 4, 1, 3, 10 };

            // Sort the integer array in ascending order.
            Array.Sort(numbers);

            Console.WriteLine("\nSorted Numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
