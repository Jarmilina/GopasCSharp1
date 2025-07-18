//Ex 40
//var globalVar = 10;

//void ExampleFunction()
//{
//    int localVar = 20;
//    Console.WriteLine("Inside the function:");
//    Console.WriteLine("Local Variable: " + localVar);
//    Console.WriteLine("Global Variable: " + globalVar);
//}

//void ExampleFunction2()
//{
//    Console.WriteLine("Inside the function:");
//    //Console.WriteLine("Local Variable: " + localVar);
//    Console.WriteLine("Global Variable: " + globalVar);
//}

//ExampleFunction();
//ExampleFunction2();


//Console.WriteLine("Inside the function:");

//Console.WriteLine("Global Variable: " + globalVar);

//// Ex 41
//int count = 0;

//void IncrementCount()
//{
//    count = count + 1;
//}

//IncrementCount();
//IncrementCount();
//IncrementCount();

//Console.WriteLine($"Outside the function, Count: {count}");

//Ex 42
int count = 0;
int IncrementCount(int countParam)
{
    //countParam++;
    //Console.WriteLine(countParam);
    return countParam++;
}

count = IncrementCount(count);
Console.WriteLine(count);
count = IncrementCount(count);
count = IncrementCount(count);
Console.WriteLine($"Outside the function, Count: {count}");
Console.WriteLine(count);