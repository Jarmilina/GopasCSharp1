int[] CreateArray(int size, int defaultValue)
{
    int[] createdArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        createdArray[i] = defaultValue;
    }

    return createdArray;
}

var testArray = CreateArray(5, 1000);
foreach (var item in testArray)
{
    Console.WriteLine(item);
}