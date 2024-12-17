using System;

namespace SampleApp.C__Basics.Arrays
{
    class MultiDimensionalArrayExamples
    {
        public void DisplayMatrixElements()
        {
            // Declare and initialize a multi-dimensional array (3x3)
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Loop through rows
            for (int i = 0; i < 3; i++)
            {
                // Loop through columns
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                // New line after each row
                Console.WriteLine();
            }
        }
    }
}
