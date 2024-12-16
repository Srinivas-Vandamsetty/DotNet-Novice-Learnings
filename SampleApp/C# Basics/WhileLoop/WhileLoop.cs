using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.WhileLoop
{
    public class WhileLoopClass
    {
        // While Loop Method 1.
        public void WhileLoopMethod()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Print the current value of i.
                Console.WriteLine(i);

                // Increment i.
                i++;
            }
        }

        // While Loop Method 2.
        public void While1()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Exit the loop when i equals 6.
                if (i == 6)
                {
                    break;
                }

                Console.WriteLine(i);

                i++;
            }
        }

        // While Loop Method 3.
        public void While2()
        {
            int i = 1;

            // Loop while i is less than 10.
            while (i < 10)
            {
                // Skip the rest of the loop when i equals 6.
                if (i == 6)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);

                i++;
            }
        }
    }
}
