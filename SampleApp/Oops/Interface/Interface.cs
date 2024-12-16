using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Oops.Interface
{
    interface IAnimal
    {
        void MakeSound(); // Method declaration
    }

    class DogInterface : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class CatInterface : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }


}
