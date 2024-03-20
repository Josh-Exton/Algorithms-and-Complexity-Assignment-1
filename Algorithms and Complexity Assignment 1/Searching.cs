namespace Algorithms_and_Complexity_Assignment_1
{
    internal class Searching
    {

        public int LinearSearch(int[] array, int value)
        {
            int counter = 0;
            int closestIndex = 0;
            int closestValue = 0;
            int difference1 = 10000;
            int difference2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine($"The Linear search did it in {counter++} steps");
                    return i;
                }
                counter++;

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
            Console.WriteLine($"The value wasn't in this linear search and the closest value is {closestValue} which is in index {closestIndex}");
            return closestIndex;
        }
        public int BinarySearch(int[] array, int value, string order)
        {
            int counter = 0;
            int beggining = 0;
            int end = array.Length - 1;
            int mid = (beggining + end) / 2;
            int closestIndex = 0;
            int closestValue = 0;
            while (((array[mid] != value) && (beggining <= end)))
            {
                if ((array[mid] < value) && order == "ascending")
                {
                    beggining = mid + 1;
                }
                else if (order == "ascending")
                {
                    end = mid - 1;
                }

                else if ((array[mid] > value) && order == "descending")
                {
                    beggining = mid + 1;
                }

                else if (order == "descending")
                {
                    end = mid - 1;
                }

                counter++;
 
                if (mid - 1 < 0 || mid + 1 > array.Length - 1)
                {
                    closestIndex = mid;
                    closestValue = array[mid];
                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which was in index {closestIndex}");
                    return closestIndex;
                }   

                else if (order == "ascending" && (array[mid - 1] < value && array[mid + 1] > value))
                {
                    int differenceLeft = value - array[mid - 1];
                    int differenceRight = array[mid + 1] - value;
                    int differenceMid = value - array[mid];
                    if (differenceMid < 0)
                    {
                        differenceMid = differenceMid * -1;
                    }
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

                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which is in index {closestIndex}");
                    return closestIndex;
                }

                else if (order == "descending" && (array[mid - 1] > value && array[mid + 1] < value))
                {
                    int differenceLeft = array[mid - 1] - value;
                    int differenceRight = value - array[mid + 1];
                    int differenceMid = value - array[mid];
                    if (differenceMid < 0)
                    {
                        differenceMid = differenceMid * -1;
                    }
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

                    Console.WriteLine($"The value wasn't in this binary search and the closest value is {closestValue} which is in index {closestIndex}");
                    return closestIndex;
                }

                mid = (beggining + end) / 2;

            }

            Console.WriteLine($"The Binary search did it in {counter} steps");
            return mid;
        }
    }
}
