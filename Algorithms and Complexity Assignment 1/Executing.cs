using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Executing
    {
        Sorting sort = new Sorting();
        Searching search = new Searching();

        public void Run(int[] array) 
        {
            int[] BubbleSortArrayAscending = array;
            sort.BubbleSort(BubbleSortArrayAscending, "ascending");
            int[] BubbleSortArrayDescending = array;
            sort.BubbleSort(BubbleSortArrayDescending, "descending");

            int[] InsertionSortArrayAscending = array;
            sort.InsertionSort(InsertionSortArrayAscending, "ascending");
            int[] InsertionSortArrayDescending = array;
            sort.InsertionSort(InsertionSortArrayDescending, "descending");

            int[] MergeSortArrayAscending = array;
            sort.MergeSort(MergeSortArrayAscending, "ascending");
            int[] MergeSortArrayDescending = array;
            sort.MergeSort(MergeSortArrayDescending, "descending");

            int[] QuickSort256Ascending = array;
            sort.InsertionSort(QuickSort256Ascending, "ascending");
            int[] QuickSort256Descending = array;
            sort.InsertionSort(QuickSort256Descending, "descending");


            if ((array.Length >= 256) && (array.Length <= 512)) 
            {
                Console.WriteLine("This is every 10th value in the ascending order");

                for (int i = 9; i < BubbleSortArrayAscending.Length; i = i + 10)
                {
                    Console.WriteLine(BubbleSortArrayAscending[i]);
                }

                Console.WriteLine("This is every 10th value in the descending order");

                for (int i = 9; i < BubbleSortArrayDescending.Length; i = i + 10)
                {
                    Console.WriteLine(BubbleSortArrayDescending[i]);
                }
            }

            else if ((array.Length >= 2048) && (array.Length <= 4096))
            {
                Console.WriteLine("This is every 50th value in the ascending order");

                for (int i = 49; i < BubbleSortArrayAscending.Length; i = i + 50)
                {
                    Console.WriteLine(BubbleSortArrayAscending[i]);
                }

                Console.WriteLine("This is every 50th value in the descending order");

                for (int i = 49; i < BubbleSortArrayDescending.Length; i = i + 50)
                {
                    Console.WriteLine(BubbleSortArrayDescending[i]);
                }

                Console.WriteLine();
                Console.WriteLine("input a integer please: ");
                string asendingInput;

                while (asendingInput.GetType() != int)
                {
                    asendingInput = Console.ReadLine();
                    try
                    {
                        asendingInput = Convert.ToInt32();
                    }
                    catch (Exception ex)
                    { 
                        Console.WriteLine("You didn't enter a integer can you please enter one");
                    }
                }

                Console.WriteLine($"Searching ascending order return {search.BinarySearch(BubbleSortArrayAscending, 1)}");


                Console.WriteLine();
                Console.WriteLine("input a integer please: ");
                string DesendingInput = Console.ReadLine();
                Console.WriteLine($"Searching descending order return {search.BinarySearch(BubbleSortArrayDescending, 1)}");
            }
        }
    }
}
