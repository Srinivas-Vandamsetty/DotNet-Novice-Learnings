using System;

namespace SampleApp.Oops.AccessControl
{
    class CarInformation
    {
        // Public field (accessible anywhere)
        public string Model = "Tesla";

        // Private field (accessible only within this class)
        private string Color = "Black";

        // Protected field (accessible within this class and derived classes)
        protected string Speed = "200km/h";

        // Display public field (Car model)
        public void DisplayModel()
        {
            Console.WriteLine($"Car Model: {Model}");
        }

        // Display private field (Car color)
        public void DisplayColor()
        {
            Console.WriteLine($"Car Color: {Color}");
        }

        // Display protected field (Car speed)
        protected void DisplaySpeed()
        {
            Console.WriteLine($"Car Speed: {Speed}");
        }

    }
}
