using System;

namespace SampleApp.Oops.Encapsulation
{
    class Person
    {
        // Properties with auto-implemented getters and setters
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        // Constructor to initialize the properties
        public Person(string name, int age, string gender, string address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        // Method to display the person's details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}