int i = 1;
while (i < 11)
{
    int x = 1;
    Console.WriteLine($"Multiplication of number: {i}");
    while (x < 11)
    {
    Console.WriteLine($"{x} * {i} = {i * x++}");
    }
    Console.WriteLine("");
    i++;
}