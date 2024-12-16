using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Oops.Polymorphism
{
    class Animal
    {

        public virtual void animalSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: Bow Bow");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Meow Meow");
        }
    }
}
