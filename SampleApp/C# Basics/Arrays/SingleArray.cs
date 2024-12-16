using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.Arrays
{
    // Class to demonstrate single-dimensional arrays.
    class SingleArrayClass
    {
        public void ArrayMethod()
        {
            // Initialize an array with a fixed size.
            int[] EvenNumbers = new int[5];

            Console.WriteLine(EvenNumbers[3]);
        }

        public void Array1()
        {
            // Declare and initialize an array.
            int[] OddNumbers = { 1, 3, 5, 7, 9 };

            Console.WriteLine(OddNumbers[3]);
        }

        public void Array2()
        {
            // Modify the third element of the array.
            string[] bikes = { "Enfield", "Yamaha", "Bajaj", "Honda" };
            bikes[2] = "Hero";

            Console.WriteLine(bikes[2]);
        }

        public void ArrayLoop()
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
