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


        int LinearSearch(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            Console.WriteLine("The item wasn't in the list returning -1");
            return -1;
        }
        public int BinarySearch(int[] arr, int value)
        {
            int beggining = 0;
            int end = arr.Length - 1;
            int mid = (beggining + end) / 2;
            while ((arr[mid] != value) && (beggining <= end))
            {
                if (arr[mid] < value)
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
