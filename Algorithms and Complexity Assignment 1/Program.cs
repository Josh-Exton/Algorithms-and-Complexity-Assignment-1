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
            Searching search = new Searching();
            Files file = new Files();
            Executing execute = new Executing();

            string fileName;

            Console.WriteLine("Do you want to open Net_1_256.txt, Net_2_256.txt, Net_3_256.txt");
            fileName = Console.ReadLine();
            int[] unsorted256 = file.TxtFile(fileName);
            while (unsorted256.Length == 0) 
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to open Net_1_256.txt, Net_2_256.txt, Net_3_256.txt");
                fileName = Console.ReadLine();
                unsorted256 = file.TxtFile(fileName);
            }

            execute.Run(unsorted256);

            Console.WriteLine("Do you want to open Net_1_2048.txt, Net_2_2048.txt, Net_3_2048.txt");
            fileName = Console.ReadLine();
            int[] unsorted2048 = file.TxtFile(fileName);
            while (unsorted2048.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to open Net_1_2048.txt, Net_2_2048.txt, Net_3_2048.txt");
                fileName = Console.ReadLine();
                unsorted256 = file.TxtFile(fileName);
            }

            execute.Run(unsorted2048);

            fileName = "Net_1_256.txt";
            int[] Net_1_256 = file.TxtFile(fileName);
            fileName = "Net_3_256.txt";
            int[] Net_3_256 = file.TxtFile(fileName);
            int[] Unsorted256Merged = Net_1_256.Concat(Net_3_256).ToArray();

            execute.Run(unsorted256);

            fileName = "Net_1_2048.txt";
            int[] Net_1_2048 = file.TxtFile(fileName);
            fileName = "Net_3_2048.txt";
            int[] Net_3_2048 = file.TxtFile(fileName);
            int[] Unsorted2048Merged = Net_1_2048.Concat(Net_3_2048).ToArray();

            execute.Run(unsorted2048);

            Console.ReadKey();
        }
    }
}
