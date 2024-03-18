using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting sort = new Sorting();
            int[] unsorted = { 5, 8, 3, 7, 6, 2, 9, 1, 4 };
            int[] sorted = unsorted;
            sort.QuickSort(sorted);
            foreach (int i in sorted)
            { 
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}