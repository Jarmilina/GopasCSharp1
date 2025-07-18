//int color = 1;
//string color = "Red";
Color color = Color.Red;

//if (color == 0)
if (color == Color.Blue)
{
    Console.WriteLine("Color is Blue");
}
//else if (color == 1)
else if (color == Color.Red)
{
    Console.WriteLine("Color is Red");
}
//else if (color == 2)
else if (color == Color.Green)
{
    Console.WriteLine("Color is Green");
}

Console.WriteLine(color);
Console.WriteLine((int)color);
//enum Color
//{
//    Blue,
//    Red,
//    Green
//}

enum Color
{
    Blue = 1,
    Red = 2,
    Green = 4
}