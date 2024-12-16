using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.ForEach
{
    class ForEachClass
    {
        public void ForEachMethod()
        {
            // Array of strings.
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Iterate over the array and print each fruit.
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }
        }

        public void ForEach1()
        {
            string[] cars = { "Tata", "Toyota", "Mahindra", "Honda", "Suzuki" };
            int[] EvenNumbers = { 2, 4, 6, 8, 10 };

            // Iterate over and print each car name.
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Iterate over and print each even number.
            foreach (int even in EvenNumbers)
            {
                Console.WriteLine(even);
            }
        }
    }
}
