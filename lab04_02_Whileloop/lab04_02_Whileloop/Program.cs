////Ex
//int i = 1;
////if (i < 6)
//while(i < 60_000)
//{
//    Console.WriteLine($"i = {i}");
//    //i += 1;
//}

//while (true)
//{

//}


//Ex28
//int i = 1;
//while (true)
//{
//    if (i >= 10000) break;
//    Console.WriteLine($"i = {i++}");
//    //i += 1;
//}
//Console.WriteLine("End of loop.");

//string current;
//Console.WriteLine("Write something: ");
//current = Console.ReadLine();

//while (current != "quit")
//{
//    Console.WriteLine($"{current} was written.");
//    Console.WriteLine("Write something: ");
//    current = Console.ReadLine();
//}

//while (true)
//{
//    Console.WriteLine("Write something: ");
//    string current = Console.ReadLine();
//    if (current == "quit")
//    {
//        break;
//    }
//    Console.WriteLine($"'{current}' was written.");
//}

//string current;
//while ((current = Console.ReadLine()) != "quit")
//{
//    Console.WriteLine($"'{current}' was written.");
//}

//int loop = 0;
//while (loop <= 5)
//{
//    loop += 1;
//    Console.WriteLine($"Outer loop: {loop}");
//}

//int loop = 0;
//while (loop <= 5)
//{
//    int i = loop * 10;
//    string s = "";
//    while (i < 100)
//    {
//        i += 10;
//        s += i.ToString() + " ";
//    }
//    Console.WriteLine($"\t{s}");
//    loop += 1;
//    Console.WriteLine($"Outer loop: {loop}");
//}

//Ex30
//int i = 1;
//while (i < 9999)
//{
//    i += 1;
//	if (i % 2 == 0)
//	{
//		continue;
//	}
//    Console.WriteLine($"i = {i}");
//}
//Console.WriteLine("End of loop.");

//Simplified:
//int i = 1;
//while (i < 9999)
//{
//    i += 2;
//	//if (i % 2 == 0)
//	//{
//	//	continue;
//	//}
//	Console.WriteLine($"i = {i}");
//}
//Console.WriteLine("End of loop.");

//Ex 31
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);