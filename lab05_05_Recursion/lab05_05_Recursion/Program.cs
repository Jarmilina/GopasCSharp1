//Ex 44
//With recursion
//int Factorial(int currentNumber)
//{
//    if (currentNumber <= 1) return 1;
//    return currentNumber * Factorial(currentNumber - 1);
//}

//Without recursion
int Factorial(int currentNumber)
{
    int result = 1;
	for (int i = 1; i <= currentNumber; i++)
	{
		result = result * i;
	}
	return result;
}

Console.WriteLine("Enter number:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Factorial of {number} is { Factorial(number) }");