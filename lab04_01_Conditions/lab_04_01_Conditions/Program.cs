//{
//    int a = 1;
//    Console.WriteLine($"a = {a}");
//}

//{
//    //int a = 2;
//    string a = "Hello World";
//    Console.WriteLine($"a = {a}");
//}

//if (DateTime.Now.Hour == 12)
//{
//    Console.WriteLine("It's noon.");
//}
//else
//{
//    Console.WriteLine("It's not noon.");
//}

//if (DateTime.Now.Hour == 12) Console.WriteLine("It's noon.");
//else Console.WriteLine("It's not noon.");

//Console.WriteLine(
//    (DateTime.Now.Hour == 12) ? "It's noon" : "It's not noon.");

//string msg = (DateTime.Now.Hour == 12) ? "It's noon" : "It's not noon.";
//Console.WriteLine(msg);

//if (true) //if + 2 x tab
//{

//}
//else //else + 2 x tab
//{

//}

////Ex 25 
//Console.WriteLine("Enter the first number:");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the operator (+, -, *, /):");
//string oper = Console.ReadLine();
//Console.WriteLine("Enter the second number:");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double result = 0;
//string message = "";

//switch (oper)
//{
//	case "+":
//		result = num1 + num2;
//		break;
//	case "-":
//        result = num1 - num2;
//		break;
//	//case "*":
//	//case "*":
//	//case "x":
//	case "*" or "x":
//		result = num1 * num2;
//		break;
//	case "/":
//		if (num2 != 0)
//		{
//            result = num1 / num2;
//        }
//		else
//		{
//			message = "Division by zero is not allowed.";
//		}
//			break;
//	default:
//		message = "Invalid operator.";
//		break;
//}

//if (message == "")
//{
//    Console.WriteLine($"Calcilatopm result {num1} {oper} {num2} = {result}.");
//}
//else
//{
//    Console.WriteLine(message);
//}

//switch (switch_on)
//{
//	default:
//}

//Ex 26

//CarType carType = CarType.Hybrid;

//switch (carType)
//{
//    case CarType.Gasoline:
//        break;
//    case CarType.Diesel:
//        break;
//    case CarType.Hybrid:
//        break;
//    case CarType.Electro:
//        break;
//    default:
//        break;
//}


//enum CarType
//{
//    Gasoline,
//    Diesel,
//    Hybrid,
//    Electro
//}

int num1;
int num2;
int num3;
int max = 0;

Console.WriteLine("Enter first value:");
bool isNumber1 = int.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Enter second number:");
bool isNumber2 = int.TryParse(Console.ReadLine(), out num2);
Console.WriteLine("Enter third number:");
bool isNumber3 = int.TryParse(Console.ReadLine(), out num3);

if (isNumber1 && isNumber2 && isNumber3)
{
    if (num1 >= num2 && num1 >= num3)
    {
        max = num1;
    }
    else //num2 and num3 left
    {
        if (num2 >= num3)
        {
            max = num2;
        }
        else
        {
            max = num3;
        }
    }
}

Console.WriteLine($"Max: {max}");