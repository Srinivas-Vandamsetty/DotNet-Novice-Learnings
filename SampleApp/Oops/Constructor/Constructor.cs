using Microsoft.VisualBasic;
using System; // Provides basic functionality like Console for input/output

// Define a class named ConstructorClass
class ConstructorClass
{
    // Instance fields to hold data for each object
    public string Name;
    public int Weight;
    public int Age;
    public string Gender;

    // Constructor to initialize the class fields
    public ConstructorClass(string name, int weight, int age, string gender)
    {
        Name = name;
        Weight = weight;
        Age = age;
        Gender = gender;
    }

    // Method to display the object's data in a formatted string
    public void DisplayData()
    {
        // Outputs the object's details to the console
        Console.WriteLine("My name is: " + Name + " and age: " + Age +
                          " & weight & Gender " + Gender + ", " + Weight);
    }

    // Static method to demonstrate creating and using an object of this class
    public static void RetriveData()
    {
        // Create an instance of ConstructorClass using the constructor
        ConstructorClass constructorObj = new ConstructorClass("Srinu", 70, 26, "Male");

        // Call the DisplayData method to print object details
        constructorObj.DisplayData();
    }
}