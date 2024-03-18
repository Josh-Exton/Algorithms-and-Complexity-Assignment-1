using System;
using System.Collections.Generic;
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

            int marker = array[0];
            int pivot = array[array.Length - 1];
            while (marker != pivot)
                if (((array[marker] > array[pivot]) && marker < pivot) || ((array[marker] < array[pivot]) && marker > pivot))

            return array;
        }

        private int[] Partioning(int[] array)
        {
            return array;
        }
    }
}