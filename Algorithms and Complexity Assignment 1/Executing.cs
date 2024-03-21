using System.Diagnostics.Metrics;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Executing
    {
        Sorting sort = new Sorting();
        Searching search = new Searching();

        private void Printing(int[] array, string order)
        {
            if ((array.Length >= 256) && (array.Length <= 512))
            {
                if (order == "ascending")
                {
                    Console.WriteLine("This is every 10th value in the ascending order");

                    for (int i = 0; i < array.Length; i = i + 10)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

                else if (order == "descending")
                {
                    Console.WriteLine("This is every 10th value in the descending order");

                    for (int i = 0; i < array.Length; i = i + 10)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

            else if ((array.Length >= 2048) && (array.Length <= 4096))
            {
                if (order == "ascending")
                {
                    Console.WriteLine("This is every 50th value in the ascending order");

                    for (int i = 0; i < array.Length; i = i + 50)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

                else if (order == "descending")
                {

                    Console.WriteLine("This is every 50th value in the descending order");

                    for (int i = 0; i < array.Length; i = i + 50)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }

        private void Input(int[] array, string order)
        {
            int number = -1;
            string input;

            while (number < 0)
            {
                Console.WriteLine("input a integer please: ");
                input = Console.ReadLine();
                input.Trim();

                if (int.TryParse(input, out int temp))
                {
                    number = temp;
                }
                else
                {
                    Console.WriteLine("You didn't enter a positive integer");
                }
            }
            search.LinearSearch(array, number);
            Console.WriteLine($"The index of the value is {search.BinarySearch(array, number, order)}");
        }

        public void AlgorithmsExecuted(int[] array) 
        {
            int[] unsortedArray = new int[array.Length];
            Array.Copy(array, unsortedArray, unsortedArray.Length);

            int[] bubbleSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, bubbleSortArrayAscending, unsortedArray.Length);
            sort.BubbleSort(bubbleSortArrayAscending, "ascending");
            int[] bubbleSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, bubbleSortArrayDescending, bubbleSortArrayDescending.Length);
            sort.BubbleSort(bubbleSortArrayDescending, "descending");

            int[] insertionSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, insertionSortArrayAscending, unsortedArray.Length);
            sort.InsertionSort(insertionSortArrayAscending, "ascending");
            int[] insertionSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, insertionSortArrayDescending, insertionSortArrayDescending.Length);
            sort.InsertionSort(insertionSortArrayDescending, "descending");

            int[] mergeSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, mergeSortArrayAscending, unsortedArray.Length);
            sort.MergeSort(mergeSortArrayAscending, "ascending");
            Console.WriteLine($"The merge sort did it in {sort.MergeCounter} steps");
            sort.ResetCounter();
            int[] mergeSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, mergeSortArrayDescending, mergeSortArrayDescending.Length);
            sort.MergeSort(mergeSortArrayDescending, "descending");
            Console.WriteLine($"The merge sort did it in {sort.MergeCounter} steps");

            int[] quickSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, quickSortArrayAscending, unsortedArray.Length);
            sort.QuickSort(quickSortArrayAscending, 0 , quickSortArrayAscending.Length - 1, "ascending");
            int[] quickSortArrayDescending = new int[unsortedArray.Length];
            Console.WriteLine($"The quick sort did it in {sort.QuickCounter} steps");
            sort.ResetCounter();
            Array.Copy(unsortedArray, quickSortArrayDescending, quickSortArrayDescending.Length);
            sort.QuickSort(quickSortArrayDescending, 0, quickSortArrayAscending.Length - 1, "descending");
            Console.WriteLine($"The quick sort did it in {sort.QuickCounter} steps");

            Printing(bubbleSortArrayAscending, "ascending");
            Printing(bubbleSortArrayDescending, "descending");

            Console.WriteLine();
            Console.WriteLine("This is for ascending list:");
            Input(bubbleSortArrayAscending, "ascending");
            Console.WriteLine();
            Console.WriteLine("This is for descending list:");
            Input(bubbleSortArrayDescending, "descending");
        }
    }
}
