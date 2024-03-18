using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Sorting
    {

        public int[] BubbleSort(int[] list)
        // public List<int> BubbleSort(List<int> list)
        {
            if (list.Length <= 1)
            {
                return list;
            }
            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        done = false;
                    }
                }
            }
            return list;
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

        public int[] QuickSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int marker = 0;
            int pivot = array.Length - 1;
            while (marker != pivot)
            {
                if (((array[marker] > array[pivot]) && marker < pivot) || ((array[marker] < array[pivot]) && marker > pivot))
                {
                    int temp = array[marker];
                    array[marker] = array[pivot];
                    array[pivot] = temp;
                }
                if (marker < pivot)
                {
                    marker++;
                }
                else
                {
                    marker--;
                }
            }
            int[] leftArray = new int[(array.Length - marker - 1)];
            Array.Copy(array, 0, leftArray, 0, (array.Length - marker - 1));
            int[] rightArray = new int[(array.Length - marker + 1)];
            Array.Copy(array, 0, rightArray, 0, (array.Length - marker + 1));
            QuickSort(leftArray);
            QuickSort(rightArray);
            int[] FinalArray = new int[array.Length];
            Array.Copy(leftArray, 0, FinalArray, 0, (array.Length - marker - 1));
            Array.Copy(array, marker, FinalArray, 0, 0);
            Array.Copy(rightArray, 0, FinalArray, 0, (array.Length - marker + 1));
            return array;
        }
        public int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            return array;
        }
    }
}