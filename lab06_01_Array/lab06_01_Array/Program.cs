////Ex 45
////int[] items;
////int[] items = new int[4];

////items[0] = 10;
////items[1] = 20;
////items[2] = 30;
////items[3] = 40;

////int[] items = new int[4] { 10, 20, 30, 40 };
////int[] items = { 10, 20, 30, 40 };
//int[] items = [ 10, 20, 30, 40 ];

////for (int i = 0; i < items.Length; i++)
////{
////    Console.WriteLine(items[i]);
////}

//foreach (var item in items)
//{
//    Console.WriteLine(item);
//    //item = 0;
//}

//// Ex 46
//string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//Console.WriteLine(weekdays[(int)DateTime.Now.DayOfWeek]);

////Ex 47
//Employee[] employees = new Employee[4];

//for (int i = 0; i < employees.Length; i++)
//{
//    Console.WriteLine("Enter a FistName:");
//    employees[i].FirstName = Console.ReadLine();
//    Console.WriteLine("Enter a LastName:");
//    employees[i].LastName = Console.ReadLine();
//}

//Console.WriteLine();
//Console.WriteLine("List of Employees:");
//foreach (var employee in employees)
//{
//    Console.WriteLine("FisrtName: {0}\nLastName: {1}", employee.FirstName, employee.LastName);
//}
//struct Employee
//{
//    public string FirstName;
//    public string LastName;
//}

//Ex 24
//int[,] myArray = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
//int[,] myArray = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80 } };
int[][] myArray = { 
	new int[] { 10, 20, 30 }, 
	new int[] { 40, 50, 60, 70, 80, 90 }, 
	new int[] { 70, 80, 90 }, 
};

for (int r = 0; r < myArray.GetLength(0); r++)
{
	//Console.WriteLine(myArray[r, 0] + ", ");
	//for (int c = 0; c < myArray.GetLength(1); c++)
	for (int c = 0; c < myArray.GetLength(0); c++)
	{
		//Console.WriteLine(myArray[r, c] + ", ");
		Console.WriteLine(myArray[r][c] + ", ");
	}
}