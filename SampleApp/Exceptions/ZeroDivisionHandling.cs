using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Exceptions
{
    class ZeroDivisionHandling
    {
        public void ExceptionMethod()
        {
            try
            {
                // Declare two numbers, one of which is zero.
                int number1 = 10;
                int number2 = 0;

                // Attempt to divide by zero. This will throw a DivideByZeroException.
                int result = number1 / number2;
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception and display an error message.
                Console.WriteLine("Error: Cannot divide by zero.");

                // Display the exception message.
                Console.WriteLine("Exception message: " + ex.Message);
            }
            finally
            {
                // Execute cleanup or final actions.
                Console.WriteLine("Execution of the try-catch block is complete.");
            }
        }
    }
}
