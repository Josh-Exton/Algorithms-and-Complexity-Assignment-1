using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Sorting
    {

        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivotIndex = left;
            int pivot = array[left];
            for (int i = left + 1; i <= right; i++) 
            {
                if (array[i] > pivot)
                {
                    pivotIndex++;
                    Swap(array, pivotIndex, i);
                }
            }
            Swap(array, pivotIndex, left);
            return pivotIndex;
        }

        private void Merge(int[] array, int[] left, int[] right)
        {
            int arrayCounter = 0;
            int leftCounter = 0;
            int rightCounter = 0;
            while (leftCounter + rightCounter < array.Length - 1)
            {
                if (left[leftCounter] >= right[rightCounter])
                {
                    array[arrayCounter] = left[leftCounter];
                    leftCounter++;
                    arrayCounter++;
                }
                else 
                {
                    array[arrayCounter] = right[rightCounter];
                    rightCounter++;
                    arrayCounter++;
                }
                if (leftCounter >= array.Length - rightCounter - 1)
                {
                    for (int i = 0; i < array.Length - leftCounter - 1; i++)
                    {
                        array[arrayCounter] = right[rightCounter];
                        rightCounter++;
                        arrayCounter++;
                    }
                }
                else if (rightCounter >= array.Length - leftCounter - 1)
                {
                    for (int i = 0; i < array.Length - rightCounter - 1; i++)
                    {
                        array[arrayCounter] = left[leftCounter];
                        leftCounter++;
                        arrayCounter++;
                    }
                }
            }
        }

        public int[] BubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        done = false;
                    }
                }
            }
            return array;
        }

        public int[] InsertionSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            for (int i = 1; i < array.Length; i++)
            {
                int currentValue = array[i];
                for (int j = i - 1; j >= 0; j--)
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
            }
            return array;
        }

        public int[] QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
            return array;
        }
        public int[] MergeSort(int[] array)
        {
            if (array.Length > 1)
            {
                int leftSize = ((array.Length) / 2);
                int rightSize = array.Length - leftSize;
                int[] left = new int[leftSize];
                int[] right = new int[rightSize];
                Array.Copy(array, 0, left, 0, leftSize);
                Array.Copy(array, leftSize, right, 0, rightSize);
                MergeSort(left);
                MergeSort(right);
                Merge(array,left,right);

            }
            return array;
        }
    }
}