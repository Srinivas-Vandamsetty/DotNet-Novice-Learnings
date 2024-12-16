using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleApp.Exceptions
{
    class HandleFileNotFound
    {
        public void HandleFileNotFoundMethod()
        {
            try
            {
                // Specify the path of a file that does not exist.
                string filePath = "nonexistentfile.txt";

                // Attempt to read the file. This will throw a FileNotFoundException.
                string content = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                // Handle the exception and display an error message.
                Console.WriteLine("Error: The file was not found.");

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
