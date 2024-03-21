using System.Diagnostics.Metrics;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Sorting
    {

        private int _quickCounter;
        private int _mergeCounter;

        public int QuickCounter
        {
            get { return _quickCounter; }
        }

        public int MergeCounter
        {
            get { return _mergeCounter; }
        }

        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private int Partition(int[] array, int left, int right, string order)
        {
            int pivotIndex = left;   
            int pivot = array[left];
            for (int i = left + 1; i <= right; i++) 
            {
                _quickCounter++;
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
            Swap(array, pivotIndex, left);
            return pivotIndex;
        }

        private void Merge(int[] array, int[] left, int[] right, string order)
        {
            int arrayIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                _mergeCounter++;
                if (order == "ascending")
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        array[arrayIndex] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        array[arrayIndex] = right[rightIndex];
                        rightIndex++;
                    }
                    arrayIndex++;
                }

                if (order == "descending")
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        array[arrayIndex] = right[rightIndex];
                        rightIndex++;
                    }
                    else
                    {
                        array[arrayIndex] = left[leftIndex];
                        leftIndex++;
                    }
                    arrayIndex++;
                }
            }
            while (leftIndex < left.Length)
            {
                array[arrayIndex] = left[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            while (rightIndex < right.Length)
            {
                array[arrayIndex] = right[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
            
        }

        public void BubbleSort(int[] array, string order)
        {
            bool done = false;
            int counter = 0;
            while (!done && ((array.Length - 1) >= 1))
            {
                done = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    counter++;
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
            Console.WriteLine($"The bubble sort did it in {counter} steps");
        }

        public void InsertionSort(int[] array, string order)
        {
            int counter = 0;
            if (array.Length >= 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int currentValue = array[i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        counter++;
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
                Console.WriteLine($"The Insertion sort did it in {counter} steps");
            }
        }

        public void QuickSort(int[] array, int left, int right, string order)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right, order);
                QuickSort(array, left, pivot - 1, order);
                QuickSort(array, pivot + 1, right, order);
            }

        }

        public void MergeSort(int[] array, string order)
        {
            if (array.Length > 1)
            {
                int leftSize = ((array.Length) / 2);
                int rightSize = array.Length - leftSize;
                int[] left = new int[leftSize];
                int[] right = new int[rightSize];
                Array.Copy(array, 0, left, 0, leftSize);
                Array.Copy(array, leftSize, right, 0, rightSize);
                MergeSort(left, order);
                MergeSort(right, order);
                Merge(array,left,right, order);
            }
        }

        public void ResetCounter()
        { 
            _quickCounter = 0;
            _mergeCounter = 0;
        }
    }
}