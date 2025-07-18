bool IsPrime(int number)
{
    //if (number == 1) return false;
    //else if ((number != 2) && (number % 2 == 0))
    //	return false;
    //else if ((number != 3) && (number % 3 == 0))
    //	return false;
    //return true;
    if (number == 1) return false;
    for (int i = 2; i < number; i++)
	{
		if (number % i == 0) return false;
	}
    return true;
}

Console.WriteLine("Insert number:");
bool result = IsPrime(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(result);