////Ex 35
//void MyFirstFunction()
//{
//    Console.WriteLine("Begin");
//    Console.WriteLine("Hello from first Function");
//    Console.WriteLine("End");
//}
/////
//void MySecondFunction()
//{
//    MyFirstFunction();
//    Console.WriteLine("...");
//    MyFirstFunction();
//    Console.WriteLine("...");
//    MyFirstFunction();
//    Console.WriteLine("...");
//}

////MyFirstFunction();
////Console.WriteLine("Hello from Program");

//MySecondFunction();

//Ex 36
//void SayHelloPaul()
//{
//    Console.WriteLine("Hello Paul");
//}

//void SayHelloJohn()
//{
//    Console.WriteLine("Hello John");
//}

//SayHelloPaul();
//SayHelloJohn();

//void SayHello(string name)
//{
//    Console.WriteLine($"Hello {name}");
//}

//SayHello("Paul");
//SayHello("John");

//void MyThreeParametrisedFunction(string name, int age, string gender)
//{
//    Console.WriteLine($"Name: {name}, age: {age}, gender: {gender}");
//}

//MyThreeParametrisedFunction("Alan", 30, "M");
//MyThreeParametrisedFunction("Gordon", 20, "F");
//MyThreeParametrisedFunction("Kelly", 35, "Not Specified");

//Ex 37
//void PrintAbsoluteValue(int value)
//{
//	if (value < 0)
//	{
//        Console.WriteLine(-value);
//	}
//	else
//	{
//        Console.WriteLine(value);
//	}
//}

//PrintAbsoluteValue(-123);
//PrintAbsoluteValue(123);

//int result = PrintAbsoluteValue(-123);
//Console.WriteLine(result);

//int GetAbsoluteValue(int value)
//{
//	//return 0;
//	if (value < 0)
//	{
//		return -value;
//	}
//	else
//	{
//		return value;
//	}
//}
//int GetAbsoluteValue(int value)
//{
//	if (value < 0) return -value;
//	return value;
//}
////GetAbsoluteValue(-123);
////GetAbsoluteValue(123);

//int result1 = GetAbsoluteValue(-123);
//int result2 = GetAbsoluteValue(123);

//Console.WriteLine(result1);
//Console.WriteLine(result2);

void PrintCounting(int count)
{
    int i = 0;
	while (true)
	{
		if (i >= count)
			return;
		i += 1;
        Console.WriteLine(i);
	}
}

PrintCounting(10);