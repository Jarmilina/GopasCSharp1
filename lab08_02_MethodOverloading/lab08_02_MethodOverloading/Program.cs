//Ex 67

Calc calc1 = new Calc();
Console.WriteLine(calc1.Sum(10, 20));
//Console.WriteLine(calc1.Sum(10, calc1.Sum(20, 30)));
Console.WriteLine(calc1.Sum(10, 20, 30));
Console.WriteLine(calc1.Sum(10L, 1000000000000000L));
class Calc
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        //return Sum(a, b) + c;
        return this.Sum(a, this.Sum(b, c));
    }

    public long Sum(long x, long y)
    {
        return x + y;
    }
}