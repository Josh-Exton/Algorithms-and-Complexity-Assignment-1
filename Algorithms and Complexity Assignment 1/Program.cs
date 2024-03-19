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
            int[] unsortedNet_1_256 = file.TxtFile("Net_1_256.txt");
            int[] unsortedNet_2_256 = file.TxtFile("Net_2_256.txt");
            int[] unsortedNet_3_256 = file.TxtFile("Net_3_256.txt");
            int[] unsortedNet_1_2048 = file.TxtFile("Net_1_2048.txt");
            int[] unsortedNet_2_2048 = file.TxtFile("Net_2_2048.txt");
            int[] unsortedNet_3_2048 = file.TxtFile("Net_3_2048.txt");
            int[] unsortedNet_1_256Net_3_256Merged = unsortedNet_1_256.Concat(unsortedNet_3_256).ToArray();
            int[] unsortedNet_1_2048Net_3_2048Merged = unsortedNet_1_2048.Concat(unsortedNet_3_2048).ToArray();
            Console.ReadKey();
        }
    }
}
