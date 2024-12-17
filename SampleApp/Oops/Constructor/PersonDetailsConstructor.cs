using System;

namespace SampleApp.Oops.Constructor
{
    class PersonDetails
    {
        private string Name;
        private string Gender;
        private int Age;

        public PersonDetails(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public void ShowDetails()
        {
            Console.WriteLine("My Name is " + Name + ", My Gender is " + Gender + ", My Age is " + Age);
        }
    }
}