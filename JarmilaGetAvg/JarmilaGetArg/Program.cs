int[] testList = [2, 4, 6, 8, 0];
Console.WriteLine(GetAvg(testList));

int GetAvg(int[] list)
{
	int sumNumbers = 0;
	//for (int i = 0; i < list.Length; i++)
	//{
	//	sumNumbers += list[i];
	//}
	foreach (var item in list)
	{
		sumNumbers += item;
	}

	return sumNumbers / list.Length;
}