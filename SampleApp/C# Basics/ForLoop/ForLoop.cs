using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.C__Basics.ForLoop
{
    class ForLoopClass
    {
        public void ForLoopMethod()
        {
            // Loop from 1 to 9, skipping 5.
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public void ForLoop1()
        {
            // Loop to print even numbers between 2 and 16.
            for (int i = 2; i < 16; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
