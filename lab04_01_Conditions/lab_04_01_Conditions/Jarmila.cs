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
    //else //num2 and num3 left
    //{
    //    if (num2 >= num3)
    //    {
    //        max = num2;
    //    }
    //    else
    //    {
    //        max = num3;
    //    }
    //}
    else if (num2 >= num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}

Console.WriteLine($"Max: {max}");