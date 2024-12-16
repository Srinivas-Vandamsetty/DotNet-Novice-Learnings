using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.TypeCasting
{
    class TypeCasting
    {
        public void TypeCastingMethod()
        {
            // Implicit casting: converting an integer to a double.
            int i = 10;
            double f = i;

            // Explicit casting: converting a double to an integer using Convert.
            double f2 = 2455.55;
            Console.WriteLine(Convert.ToInt32(f2));
        }
    }
}
