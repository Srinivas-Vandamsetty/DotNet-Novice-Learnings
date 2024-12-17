using System;

namespace SampleApp.C__Basics.DataTypes
{
    class DataTypeExamples
    {
        public void DisplayDataTypes()
        {
            // Declare and initialize variables of different data types.
            int maxNumber = 2147483647;
            long largeValue = -9223372036854775;
            double decimalPoints = 999.999999;
            char initial = 'B';
            string fullName = "Ms Dhoni";

            // Print the values of the variables.
            Console.WriteLine(maxNumber);
            Console.WriteLine(largeValue);
            Console.WriteLine(decimalPoints);
            Console.WriteLine(initial);
            Console.WriteLine(fullName);
        }
    }
}
