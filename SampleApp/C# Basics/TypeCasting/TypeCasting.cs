using System;

namespace SampleApp.C__Basics.TypeCasting
{
    class TypeCastingExamples
    {
        public void DisplayTypeCastingExamples()
        {
            // Implicit casting: converting an integer to a double.
            int i = 10;
            double f = i;
            Console.WriteLine("Implicit Casting (int to double): " + f);

            // Explicit casting: converting a double to an integer using Convert.
            double f2 = 2455.55;
            Console.WriteLine("Explicit Casting (double to int using Convert): " + Convert.ToInt32(f2));

            // Explicit casting: converting a double to an integer using (int) syntax.
            double f3 = 12.99;
            int i2 = (int)f3;
            Console.WriteLine("Explicit Casting (double to int using (int)): " + i2);

            // Implicit casting: converting a smaller numeric type to a larger one.
            byte b = 100;
            int i3 = b;
            Console.WriteLine("Implicit Casting (byte to int): " + i3);

            // Explicit casting: converting a larger numeric type to a smaller one.
            int i4 = 300;
            byte b2 = (byte)i4;
            Console.WriteLine("Explicit Casting (int to byte): " + b2);

            // Type casting with string to numeric types.
            string str = "123.45";
            double d = Convert.ToDouble(str);
            Console.WriteLine("String to double: " + d);

            // Converting an integer to a string.
            int i5 = 456;
            string str2 = i5.ToString();
            Console.WriteLine("Integer to string: " + str2);
        }
    }
}
