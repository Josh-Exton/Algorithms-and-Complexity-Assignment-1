namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Searching
    {
        /// <summary>
        /// Performs the linear search algorithm
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="value">The inputer value you are searching for </param>
        /// <returns></returns>
        public int LinearSearch(int[] array, int value)
        {
            int counter = 0;
            int closestIndex = 0;
            int closestValue = 0;
            int difference1 = 10000;
            int difference2;
            for (int i = 0; i < array.Length; i++)
            {
                // Checking if the element is the value
                if (array[i] == value)
                {
                    Console.WriteLine($"The Linear search did it in {counter++} steps");
                    return i;
                }
                // Incrementing counter
                counter++;

                // Incease it is not in the list I am storing the closest value
                difference2 = value - array[i];
                if (difference2 < 0)
                {
                    difference2 = difference2 * -1;
                }

                if (difference1 > difference2)
                {
                    closestIndex = i;
                    closestValue = array[i];
                    difference1 = difference2;
                }
            }
            // returning closest value
            Console.WriteLine($"The value wasn't in this linear search and the closest value is {closestValue} which is in index {closestIndex}");
            return closestIndex;
        }
        public int BinarySearch(int[] array, int value, string order)
        {
            // getting the pointers
            int counter = 0;
            int beggining = 0;
            int end = array.Length - 1;
            int mid = (beggining + end) / 2;
            int closestIndex = 0;
            int closestValue = 0;

            // looping the until the end reaches the the indexs are the same or the value is found
            while (((array[mid] != value) && (beggining <= end)))
            {
                // Checking if mid greater or less than value
                if ((array[mid] < value) && order == "ascending")
                {
                    // updating begginning pointer
                    beggining = mid + 1;
                }
                else if (order == "ascending")
                {
                    // updating end pointer
                    end = mid - 1;
                }

                else if ((array[mid] > value) && order == "descending")
                {
                    // updating begginning pointer
                    beggining = mid + 1;
                }

                else if (order == "descending")
                {
                    // updating end pointer
                    end = mid - 1;
                }

                // Incrementing vounter
                counter++;

                // Checking if mid is on the end because if it is and not the value it is not in the list
                if (mid - 1 < 0 || mid + 1 > array.Length - 1)
                {
                    closestIndex = mid;
                    closestValue = array[mid];
                    // returning closest index and printing value
                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which was in index {closestIndex}");
                    return closestIndex;
                }   

                // it the left item is less than value and right item is more than value and mid isn't value the item is not in the list
                else if (order == "ascending" && (array[mid - 1] < value && array[mid + 1] > value))
                {
                    // checking the difference from the between the mid, left and right element 
                    int differenceLeft = value - array[mid - 1];
                    int differenceRight = array[mid + 1] - value;
                    int differenceMid = value - array[mid];
                    if (differenceMid < 0)
                    {
                        differenceMid = differenceMid * -1;
                    }
                    // seeing which is closest
                    if ((differenceLeft <= differenceRight) && (differenceLeft <= differenceMid))
                    {
                        closestIndex = mid - 1;
                        closestValue = array[mid - 1];
                    }
                    else if ((differenceLeft > differenceRight) && (differenceMid > differenceRight))
                    {
                        closestIndex = mid + 1;
                        closestValue = array[mid + 1];
                    }
                    else
                    {
                        closestIndex = mid;
                        closestValue = array[mid];
                    }
                    // returning closest index and printing value
                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which is in index {closestIndex}");
                    return closestIndex;
                }

                // same as ascending but reversed
                else if (order == "descending" && (array[mid - 1] > value && array[mid + 1] < value))
                {
                    // checking the difference from the between the mid, left and right element 
                    int differenceLeft = array[mid - 1] - value;
                    int differenceRight = value - array[mid + 1];
                    int differenceMid = value - array[mid];

                    if (differenceMid < 0)
                    {
                        differenceMid = differenceMid * -1;
                    }
                    // seeing which is closest
                    if ((differenceLeft <= differenceRight) && (differenceLeft <= differenceMid))
                    {
                        closestIndex = mid - 1;
                        closestValue = array[mid - 1];
                    }
                    else if ((differenceLeft > differenceRight) && (differenceMid > differenceRight))
                    {
                        closestIndex = mid + 1;
                        closestValue = array[mid + 1];
                    }
                    else
                    {
                        closestIndex = mid;
                        closestValue = array[mid];
                    }
                    // returning closest index and printing value
                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which is in index {closestIndex}");
                    return closestIndex;
                }
                // Updating mid

                mid = (beggining + end) / 2;

            }

            Console.WriteLine($"The Binary search did it in {counter} steps");
            return mid;
        }
    }
}
