int number;
Console.WriteLine("Enter a number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out number);

int i = 1;
while (i < 11)
{
    Console.WriteLine($"{i} * {number} = {i++ * number}");
}