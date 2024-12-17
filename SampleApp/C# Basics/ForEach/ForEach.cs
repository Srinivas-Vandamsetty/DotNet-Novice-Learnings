using System;

namespace SampleApp.C__Basics.ForEach
{
    class ForEachLoopExamples
    {
        // Method to demonstrate ForEach loop to display fruits.
        public void DisplayFruitsUsingForEach()
        {
            // Array of strings.
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Iterate over the array and print each fruit.
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }
        }

        // Method to demonstrate ForEach loop to display cars and even numbers.
        public void DisplayCarsAndEvenNumbers()
        {
            string[] cars = { "Tata", "Toyota", "Mahindra", "Honda", "Suzuki" };
            int[] evenNumbers = { 2, 4, 6, 8, 10 };

            // Iterate over and print each car name.
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Iterate over and print each even number.
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            }
        }
    }
}
