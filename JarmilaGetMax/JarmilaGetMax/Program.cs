int[] testArray = { 3, 5, 7, - 4, 8, 1 };
Console.WriteLine(GetMax(testArray));

int GetMax(int[] numbers)
{
	int maxNow = int.MinValue;
	//for (int i = 0; i < (numbers.Length - 1); i++)
	//{
	//      int[] remainingNumbers = new int[numbers.Length - 1];
	//      if (numbers[i] < numbers[i + 1])
	//	continue;
	//else
	//{
	//	for (int ii = 1; ii < numbers.Length; ii++)
	//	{
	//		remainingNumbers[i] = numbers[ii];
	//	}
	//	maxNow = GetMax(remainingNumbers);
	//}
	//}
	for (int i = 0; i < numbers.Length; i++)
	{
		if (maxNow < numbers[i])
		{
			maxNow = numbers[i];
		}
	}
	return maxNow;
}

