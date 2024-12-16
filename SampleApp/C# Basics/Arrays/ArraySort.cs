using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.Arrays
{
    class ArraySortClass
    {
        // Method to sort and display arrays.
        public void ArraySortMethod()
        {
            
            string[] Names = { "Sai", "Rajesh", "Akash", "Nagendra", "Praveen" };

            // Sort the string array in ascending order.
            Array.Sort(Names);
           
            Console.WriteLine("Sorted Names:");
            foreach (string i in Names)
                Console.WriteLine(i);

            // Define and initialize an integer array.
            int[] numbers = { 5, 6, 7, 2, 4, 1, 3, 10 };

            // Sort the integer array in ascending order.
            Array.Sort(numbers);

            Console.WriteLine("\nSorted Numbers:");
            foreach (int j in numbers)
            {
                Console.WriteLine(j);
            }
        }
    }
}
