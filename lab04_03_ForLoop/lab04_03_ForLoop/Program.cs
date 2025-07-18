////Ex32
//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//Ex 33
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i = {i}");
//}
//Console.WriteLine($"i = {i}"); //Error - does not exist outside loop

//int i;
//for (i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i = {i}");
//}
//Console.WriteLine($"i = {i}");

//Ex34
//for (int i = 2; i < 256; i += Convert.ToInt32(Math.Pow(i,2)))
//{
//    Console.WriteLine($"i = {i}");
//}

//for (int i = 0, j = 10; i < 10; i++, j--)
//{
//    Console.WriteLine("i = {0}, j = {1}", i, j);
//}

//for (int i = 0; i < 10; )
//{
//    Console.WriteLine(i++);
//}

//for (int i = 0; ; )
//{
//	if (i >= 10)
//	{
//		break;
//	}
//    Console.WriteLine(i++);
//}

//int i = 0;
//for (; ; )
//{
//	if (i >= 10)
//	{
//		break;
//	}
//    Console.WriteLine(i++);
//}

for (int i = 0; i >= 10; i--)
{
	for (int j = 0; j < 10; j++)
	{
        Console.WriteLine($"i: {i}, j: {j}");
	}
}