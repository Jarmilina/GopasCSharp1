//int[] list = { 10, 20, 30 };
//System.Collections.ArrayList list = new System.Collections.ArrayList();
System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
list.Add(10);
list.Add(20);
list.Add(30);

foreach (var item in list)
{
    Console.WriteLine($"Value: {item}");
}

list.Remove(10);

foreach (var item in list)
{
    Console.WriteLine($"Value: {item}");
}

Console.WriteLine("");

list.Insert(1, 10);

foreach (var item in list)
{
    Console.WriteLine($"Value: {item}");
}

Console.WriteLine(list[1]);
list[1] = 25;
Console.WriteLine(list[1]);

//Ex 50
Console.WriteLine("Enter a number:");
list.Add(Convert.ToInt32(Console.ReadLine()));

foreach (int item in list)
{
    Console.WriteLine($"Value: {item}");
}