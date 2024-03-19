using System;
using System.Collections.Generic;
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
    internal class Searching
    {


        int LinearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            Console.WriteLine("The item wasn't in the list returning -1");
            return -1;
        }
        public int BinarySearch(int[] array, int value)
        {
            int beggining = 0;
            int end = array.Length - 1;
            int mid = (beggining + end) / 2;
            while ((array[mid] != value) && (beggining <= end))
            {
                if (array[mid] < value)
                {
                    beggining = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                mid = (beggining + end) / 2;
            }
            if (beggining > end)
            {
                Console.WriteLine("The item wasn't in the list returning -1");
                return -1;
            }
            return mid;
        }
    }
}
