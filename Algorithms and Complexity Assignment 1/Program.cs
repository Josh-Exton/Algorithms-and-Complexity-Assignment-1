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

int BinarySearch(int[] arr, int value)
{
    int beggining = 0;
    int end = arr.Length - 1;
    int mid = (beggining + end) / 2;
    while ((arr[mid] != value)  && (beggining <= end))
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


int[] array = { 3,9,2,5,1,4,8};

int[] sorted = { 1,2,3,4,5,6,7 };

Console.WriteLine(LinearSearch(array, 5));
Console.ReadKey();