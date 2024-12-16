using System;

namespace SampleApp.Oops.Abstraction
{
    // Abstract class representing a generic vehicle.
    abstract class VehicleAbstraction
    {
        // Abstract method to be implemented by derived classes.
        public abstract void DisplayInfo();

        // Concrete method that can be used by all derived classes.
        public void Move()
        {
            Console.WriteLine("Vehicle is moving");
        }
    }

    // Class representing a car, inheriting from VehicleAbstraction.
    class CarAbstraction : VehicleAbstraction
    {
        public int MaxSpeed = 500;
        public int Wheels = 4;

        // Override method to display car-specific details.
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Details: Max Speed = {MaxSpeed} km/h, Wheels = {Wheels}");
        }
    }

    // Class representing a bike, inheriting from VehicleAbstraction.
    class BikeAbstraction : VehicleAbstraction
    {
        public int MaxSpeed = 200;
        public int Wheels = 2;

        // Override method to display bike-specific details.
        public override void DisplayInfo()
        {
            Console.WriteLine($"Bike Details: Max Speed = {MaxSpeed} km/h, Wheels = {Wheels}");
        }
    }

    // Class representing a boat, inheriting from VehicleAbstraction.
    class BoatAbstraction : VehicleAbstraction
    {
        public int MaxSpeed = 300;
        public int Wheels = 0;

        // Override method to display boat-specific details.
        public override void DisplayInfo()
        {
            Console.WriteLine($"Boat Details: Max Speed = {MaxSpeed} km/h, Wheels = {Wheels}");
        }
    }
}
