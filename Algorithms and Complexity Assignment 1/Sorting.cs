using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Sorting
    {

        private int[] _array;

        public int[] Array
        {
            get { return _array; } 
            set { _array = value; }
        }

        public Sorting(int[] arr)
        {
            _array = arr;
        }

        public int[] BubbleSort(int[] arr)
        {
            return arr;
        }
    }
}
