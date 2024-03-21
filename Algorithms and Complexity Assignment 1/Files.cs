using System;
using System.IO;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Files
    {
        /// <summary>
        /// Turns a txt file of integers into an array
        /// </summary>
        /// <param name="fileName">The file name</param>
        /// <returns>The array</returns>
        public int[] TxtFileToArray(string fileName)
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            string filePath = Path.Combine(currentDirectory, fileName);

            // Try statemnt in case it is not in the list
            try
            {
                // using the StreamReader libery
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    // Reading evey line
                    int lineCounter = File.ReadAllLines(filePath).Length;

                    int[] array = new int[lineCounter];
                    int arrayIndex = 0;

                    // Getting the conent
                    string lineContent = streamReader.ReadLine();

                    while (lineContent != null)
                    {
                        // Turning the content into an int and returns false if it doesn't 
                        if (int.TryParse(lineContent, out int number))
                        {
                            // addinging it to the array
                            array[arrayIndex] = number;
                            arrayIndex++;
                        }
                        else
                        {
                            Console.WriteLine($"Failed to parse line '{lineContent}' as an integer.");
                        }
                        lineContent = streamReader.ReadLine();
                    }
                    // returns the array
                    return array;
                }
            }

            // Catches ut and returns and empty array
            catch (Exception ex) 
            {
                Console.WriteLine("An error occurred while opening the file so we are returning a empty array:");
                Console.WriteLine (ex.Message);
                int[] array = new int[0];
                return array;
            }
        }
    }
}
