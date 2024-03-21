using System.Diagnostics.Metrics;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Sorting
    {
        // Counters for the sorting algorithms with recursion
        private int _quickCounter;
        private int _mergeCounter;

        /// <summary>
        /// Gets the counter for the quick sort algorithm
        /// </summary>
        public int QuickCounter
        {
            get { return _quickCounter; }
        }

        /// <summary>
        /// Gets the counter for the merge sort algorithm
        /// </summary>
        public int MergeCounter
        {
            get { return _mergeCounter; }
        }

        /// <summary>
        /// Swaps two items in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right Index</param>
        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        /// <summary>
        /// Gets the pivot value in the right location and all elements to the left are less than and to the right are right than 
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right index</param>
        /// <param name="order">ascending or descending order</param>
        /// <returns>The pivot index</returns>
        private int Partition(int[] array, int left, int right, string order)
        {
            int pivotIndex = left;   
            int pivot = array[left];
            // Loop through the array
            for (int i = left + 1; i <= right; i++) 
            {
                // Increments the counter
                _quickCounter++;
                // Checks if items need swaping
                if (order == "ascending" && (array[i] < pivot))
                {
                    pivotIndex++;
                    Swap(array, pivotIndex, i);
                }
                if (order == "descending" && (array[i] > pivot))
                {
                    pivotIndex++;
                    Swap(array, pivotIndex, i);
                }
            }
            // Final swap to get the pivot in the correct part
            Swap(array, pivotIndex, left);
            return pivotIndex;
        }

        /// <summary>
        /// Takes two arrays and merges them into the correct order in another array
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="left">The left array</param>
        /// <param name="right">The right array</param>
        /// <param name="order">ascending or descending order</param>
        private void Merge(int[] array, int[] left, int[] right, string order)
        {
            int arrayIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;
            // Looping through the array
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                // Incrementing the counter
                _mergeCounter++;
                // Checks the first element each array to 
                if (order == "ascending")
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        array[arrayIndex] = left[leftIndex];
                        // Incrementing the index
                        leftIndex++;
                    }
                    else
                    {
                        array[arrayIndex] = right[rightIndex];
                        // Incrementing the index
                        rightIndex++;
                    }
                    arrayIndex++;
                }

                if (order == "descending")
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        array[arrayIndex] = right[rightIndex];
                        // Incrementing the index
                        rightIndex++;
                    }
                    else
                    {
                        array[arrayIndex] = left[leftIndex];
                        // Incrementing the index
                        leftIndex++;
                    }
                    arrayIndex++;
                }
            }

            // filling in the merged array with the left list elements
            while (leftIndex < left.Length)
            {
                array[arrayIndex] = left[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            // filling in the merged array with the right list elements
            while (rightIndex < right.Length)
            {
                array[arrayIndex] = right[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
            
        }

        /// <summary>
        /// Sorts an array using the bubble sort algorithm
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="order">ascending or descending order</param>
        public void BubbleSort(int[] array, string order)
        {
            bool done = false;
            int counter = 0;
            // Looping until it does a full pass without sorting
            while (!done && ((array.Length - 1) >= 1))
            {
                done = true;
                // Looping through the array
                for (int i = 0; i < array.Length - 1; i++)
                {
                    // Incrementing counter
                    counter++;
                    // Checking if itemns need to be swaped
                    if (order == "ascending" && (array[i] > array[i + 1]))
                    {
                        Swap(array, i, i + 1);
                        done = false;
                    }
                    else if (order == "descending" && (array[i] < array[i + 1]))
                    {
                        Swap(array, i, i + 1);
                        done = false;
                    }
                }
            }
            // Printing the amount of steps
            Console.WriteLine($"The bubble sort did it in {counter} steps");
        }

        /// <summary>
        /// Sorts an array using the Insersion sort algorithm
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="order">ascending or descending order</param>
        public void InsertionSort(int[] array, string order)
        {
            int counter = 0;
            if (array.Length >= 1)
            {
                // Loops through the unsorte part
                for (int i = 1; i < array.Length; i++)
                {
                    // Loops through the sorted part
                    int currentValue = array[i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        // Incrementing the counter
                        counter++;
                        // Checking where the unsorted item lies in the sorted part
                        if (order == "ascending")
                        {

                            if (currentValue > array[j])
                            {
                                break;
                            }
                            else
                            {
                                array[j + 1] = array[j];
                                array[j] = currentValue;
                            }
                        }

                        else if (order == "descending")
                        {
                            if (currentValue < array[j])
                            {
                                break;
                            }
                            else
                            {
                                array[j + 1] = array[j];
                                array[j] = currentValue;
                            }
                        }
                    }
                }
                // Printing the amount of steps
                Console.WriteLine($"The Insertion sort did it in {counter} steps");
            }
        }

        /// <summary>
        /// Sorts an array using the quick sort algorithm
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="left">The left index(beggining)</param>
        /// <param name="right">The right index(end)</param>
        /// <param name="order">ascending or descending order</param>
        public void QuickSort(int[] array, int left, int right, string order)
        {
            if (left < right)
            {
                // Calls the partition method
                int pivot = Partition(array, left, right, order);
                // Recursion calls
                QuickSort(array, left, pivot - 1, order);
                QuickSort(array, pivot + 1, right, order);
            }

        }

        /// <summary>
        /// Sorts an array using the merge sort algorithm
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="order">ascending or descending order</param>
        public void MergeSort(int[] array, string order)
        {
            // Checkes if the length of array is more the 1 so the recursion stops
            if (array.Length > 1)
            {
                // Spliting the array in half
                int leftSize = ((array.Length) / 2);
                int rightSize = array.Length - leftSize;
                int[] left = new int[leftSize];
                int[] right = new int[rightSize];
                Array.Copy(array, 0, left, 0, leftSize);
                Array.Copy(array, leftSize, right, 0, rightSize);
                // Recursion call
                MergeSort(left, order);
                MergeSort(right, order);
                // Calling the merge method
                Merge(array,left,right, order);
            }
        }

        /// <summary>
        /// Resets the counter properties
        /// </summary>
        public void ResetCounter()
        { 
            _quickCounter = 0;
            _mergeCounter = 0;
        }
    }
}