int GetMax(int[] list)
{
    int max = list[0];
	for (int i = 0; i < list.Length; i++)
	{
		if (list[i] > max)
		{
			max = list[i];
		}
	}
	return max;
}

int[] list = { 3, 5, 9, 12, 27, 3, 6, 9 };
Console.WriteLine($"Maximum number is: {GetMax(list)}");
Console.WriteLine($"Maximum number is: {GetMax(list)}");