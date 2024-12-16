using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Oops.Constructor
{
    class NewConstructor
    {
        private string Name;
        private string Gender;
        private int Age;

        public NewConstructor(string name, string gender, int age)
        {
           Name = name;
           Gender = gender;
           Age = age;

        }

        public void DisplayData()
        {
            Console.WriteLine($"My Name is {Name} " );
        }

    }
 }
