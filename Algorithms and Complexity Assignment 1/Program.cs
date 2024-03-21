using System;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Creating the objects
            Files file = new Files();
            Executing execute = new Executing();

            // Asking the user for the 256 file
            Console.WriteLine("Do you want to open Net_1_256.txt, Net_2_256.txt, Net_3_256.txt");
            string fileName = Console.ReadLine();
            int[] unsorted256 = file.TxtFileToArray(fileName);
            // I return a emtpy array if the file doesn't exist so it loop if that happens
            while (unsorted256.Length == 0) 
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to open Net_1_256.txt, Net_2_256.txt, Net_3_256.txt");
                fileName = Console.ReadLine();
                unsorted256 = file.TxtFileToArray(fileName);
            }

            // Executing the algorithms
            execute.AlgorithmsExecuted(unsorted256);

            // Asking the user for the 2048 file
            Console.WriteLine();
            Console.WriteLine("Do you want to open Net_1_2048.txt, Net_2_2048.txt, Net_3_2048.txt");
            fileName = Console.ReadLine();
            int[] unsorted2048 = file.TxtFileToArray(fileName);
            // I return a emtpy array if the file doesn't exist so it loop if that happens
            while (unsorted2048.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to open Net_1_2048.txt, Net_2_2048.txt, Net_3_2048.txt");
                fileName = Console.ReadLine();
                unsorted2048 = file.TxtFileToArray(fileName);
            }

            // Executing the algorithms
            execute.AlgorithmsExecuted(unsorted2048);

            // the 256 merged array
            Console.WriteLine();
            Console.WriteLine("This is the 256 merged array");
            fileName = "Net_1_256.txt";
            int[] Net_1_256 = file.TxtFileToArray(fileName);
            fileName = "Net_3_256.txt";
            int[] Net_3_256 = file.TxtFileToArray(fileName);
            // concatenating the arrays
            int[] Unsorted256Merged = Net_1_256.Concat(Net_3_256).ToArray();

            // Executing the algorithms
            execute.AlgorithmsExecuted(Unsorted256Merged);

            // the 2048 merged array
            Console.WriteLine();
            Console.WriteLine("This is the 2048 merged array");
            fileName = "Net_1_2048.txt";
            int[] Net_1_2048 = file.TxtFileToArray(fileName);
            fileName = "Net_3_2048.txt";
            int[] Net_3_2048 = file.TxtFileToArray(fileName);
            // concatenating the arrays
            int[] Unsorted2048Merged = Net_1_2048.Concat(Net_3_2048).ToArray();

            // Executing the algorithms
            execute.AlgorithmsExecuted(Unsorted2048Merged);

            Console.WriteLine();
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
} 
