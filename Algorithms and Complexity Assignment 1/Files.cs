using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Files
    {
        public int[] TxtFile (string fileName)
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            string filePath = Path.Combine(currentDirectory, fileName);

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;

                    int[] array = new int[lineCounter];
                    int arrayIndex = 0;

                    string lineContent = streamReader.ReadLine();

                    while (lineContent != null)
                    {
                        if (int.TryParse(lineContent, out int number))
                        {
                            array[arrayIndex] = number;
                            arrayIndex++;
                        }
                        else
                        {
                            Console.WriteLine($"Failed to parse line '{lineContent}' as an integer.");
                        }
                        lineContent = streamReader.ReadLine();
                    }

                    return array;
                }
            }

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