using System.Diagnostics.Metrics;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Executing
    {
        // Creating the objects
        Sorting sort = new Sorting();
        Searching search = new Searching();

        /// <summary>
        /// Print every 10th or every 50th value
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="order">Ascending or descending order</param>
        private void Printing(int[] array, string order)
        {
            // Checking array length
            if ((array.Length >= 256) && (array.Length <= 512))
            {
                if (order == "ascending")
                {
                    Console.WriteLine("This is every 10th value in the ascending order");

                    // Printing every 10th value
                    for (int i = 0; i < array.Length; i = i + 10)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

                else if (order == "descending")
                {
                    Console.WriteLine("This is every 10th value in the descending order");

                    // Printing every 10th value
                    for (int i = 0; i < array.Length; i = i + 10)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

            // Checking array length
            else if ((array.Length >= 2048) && (array.Length <= 4096))
            {
                if (order == "ascending")
                {
                    Console.WriteLine("This is every 50th value in the ascending order");

                    // Printing every 50th value
                    for (int i = 0; i < array.Length; i = i + 50)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

                else if (order == "descending")
                {

                    Console.WriteLine("This is every 50th value in the descending order");

                    // Printing every 50th value
                    for (int i = 0; i < array.Length; i = i + 50)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Gets an input and calls the search function
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="order">Ascending or descending order</param>
        private void Input(int[] array, string order)
        {
            // Setting variable or the number
            int number = -1;
            string input;

            // while loop until the person enters an integer nmber
            while (number < 0)
            {
                // Gets user input
                Console.WriteLine("input a integer please: ");
                input = Console.ReadLine();
                input.Trim();
                // Turns it into an integer
                if (int.TryParse(input, out int temp))
                {
                    number = temp;
                }
                else
                {
                    Console.WriteLine("You didn't enter a positive integer");
                }
            }
            // Calls the searches
            search.LinearSearch(array, number);
            Console.WriteLine($"The index of the value is {search.BinarySearch(array, number, order)}");
        }

        public void AlgorithmsExecuted(int[] array) 
        {
            // Have to create an empy array of an sertain length to pass by value and not by reference
            int[] unsortedArray = new int[array.Length];
            Array.Copy(array, unsortedArray, unsortedArray.Length);

            // Creates the array the same way and does the bubble sort
            int[] bubbleSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, bubbleSortArrayAscending, unsortedArray.Length);
            sort.BubbleSort(bubbleSortArrayAscending, "ascending");
            int[] bubbleSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, bubbleSortArrayDescending, bubbleSortArrayDescending.Length);
            sort.BubbleSort(bubbleSortArrayDescending, "descending");

            // Creates the array the same way and does the insertion sort
            int[] insertionSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, insertionSortArrayAscending, unsortedArray.Length);
            sort.InsertionSort(insertionSortArrayAscending, "ascending");
            int[] insertionSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, insertionSortArrayDescending, insertionSortArrayDescending.Length);
            sort.InsertionSort(insertionSortArrayDescending, "descending");

            // Creates the array the same way and does the merge sort
            int[] mergeSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, mergeSortArrayAscending, unsortedArray.Length);
            sort.MergeSort(mergeSortArrayAscending, "ascending");
            // Printing the ammount of steps
            Console.WriteLine($"The merge sort did it in {sort.MergeCounter} steps");
            // reseting the counter
            sort.ResetCounter();
            int[] mergeSortArrayDescending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, mergeSortArrayDescending, mergeSortArrayDescending.Length);
            sort.MergeSort(mergeSortArrayDescending, "descending");
            Console.WriteLine($"The merge sort did it in {sort.MergeCounter} steps");

            // Creates the array the same way and does the quicksort sort
            int[] quickSortArrayAscending = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, quickSortArrayAscending, unsortedArray.Length);
            sort.QuickSort(quickSortArrayAscending, 0 , quickSortArrayAscending.Length - 1, "ascending");
            int[] quickSortArrayDescending = new int[unsortedArray.Length];
            // Printing the ammount of steps
            Console.WriteLine($"The quick sort did it in {sort.QuickCounter} steps");
            // reseting the counter
            sort.ResetCounter();
            Array.Copy(unsortedArray, quickSortArrayDescending, quickSortArrayDescending.Length);
            sort.QuickSort(quickSortArrayDescending, 0, quickSortArrayAscending.Length - 1, "descending");
            Console.WriteLine($"The quick sort did it in {sort.QuickCounter} steps");

            // Calling the printing method
            Printing(bubbleSortArrayAscending, "ascending");
            Printing(bubbleSortArrayDescending, "descending");

            // Calling the input method
            Console.WriteLine();
            Console.WriteLine("This is for ascending list:");
            Input(bubbleSortArrayAscending, "ascending");
            Console.WriteLine();
            Console.WriteLine("This is for descending list:");
            Input(bubbleSortArrayDescending, "descending");
        }
    }
}
