using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting sort = new Sorting();
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "Net_1_256.txt";
            string filePath = Path.Combine(currentDirectory, fileName);
            string lineContent;
            int arrayIndex = 0;
            try
            {
                using (StreamReader Streamreader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;
                    int [] Net_1_256Array = new int[lineCounter];
                    lineContent = Streamreader.ReadLine();
                    while (lineContent != null)
                    {
                        int.TryParse(lineContent, out int number);
                        Net_1_256Array[arrayIndex] = number;
                        arrayIndex++;
                        lineContent = Streamreader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file:");
                Console.WriteLine(e.Message);
            }

            fileName = "Net_2_256.txt";
            filePath = Path.Combine(currentDirectory, fileName);
            arrayIndex = 0;
            try
            {
                using (StreamReader Streamreader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;
                    int[] Net_2_256Array = new int[lineCounter];
                    lineContent = Streamreader.ReadLine();
                    while (lineContent != null)
                    {
                        int.TryParse(lineContent, out int number);
                        Net_2_256Array[arrayIndex] = number;
                        arrayIndex++;
                        lineContent = Streamreader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file:");
                Console.WriteLine(e.Message);
            }

            fileName = "Net_3_256.txt";
            filePath = Path.Combine(currentDirectory, fileName);
            arrayIndex = 0;
            try
            {
                using (StreamReader Streamreader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;
                    int[] Net_3_256Array = new int[lineCounter];
                    lineContent = Streamreader.ReadLine();
                    while (lineContent != null)
                    {
                        int.TryParse(lineContent, out int number);
                        Net_3_256Array[arrayIndex] = number;
                        arrayIndex++;
                        lineContent = Streamreader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file:");
                Console.WriteLine(e.Message);
            }

            fileName = "Net_1_2048.txt";
            filePath = Path.Combine(currentDirectory, fileName);
            arrayIndex = 0;
            try
            {
                using (StreamReader Streamreader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;
                    int[] Net_1_2048Array = new int[lineCounter];
                    lineContent = Streamreader.ReadLine();
                    while (lineContent != null)
                    {
                        int.TryParse(lineContent, out int number);
                        Net_1_2048Array[arrayIndex] = number;
                        arrayIndex++;
                        lineContent = Streamreader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file:");
                Console.WriteLine(e.Message);
            }

            fileName = "Net_2_2048.txt";
            filePath = Path.Combine(currentDirectory, fileName);
            arrayIndex = 0;
            try
            {
                using (StreamReader Streamreader = new StreamReader(filePath))
                {
                    int lineCounter = File.ReadAllLines(filePath).Length;
                    int[] Net_2_2048Array = new int[lineCounter];
                    lineContent = Streamreader.ReadLine();
                    while (lineContent != null)
                    {
                        int.TryParse(lineContent, out int number);
                        Net_2_2048Array[arrayIndex] = number;
                        arrayIndex++;
                        lineContent = Streamreader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while opening the file:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
