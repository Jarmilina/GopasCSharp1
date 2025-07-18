
static void Calculate()
{
    try
    {
        Console.WriteLine("Enter A:");
        int numberA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter B:");
        int numberB = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} / {1} = {2}", numberA, numberB, numberA / numberB);
    }
    catch (System.DivideByZeroException ex)
    {
        Console.WriteLine("Zero division erro");
        //throw ex;
        //throw new Exception("Error in Calculate()");
        throw new Exception("Error in Calculate()", ex);
    }
    catch (System.OverflowException ex)
    {
        Console.WriteLine("Value is out of range " + int.MinValue + " to " + int.MaxValue);
    }
    //catch (System.Exception ex)
    //{
    //    Console.WriteLine(ex.Message + ex.Source + ex.StackTrace);
    //}
}

try
{
    Calculate();
}
catch (Exception ex)
{
    if (ex.InnerException != null)
    {
        Console.WriteLine(ex.InnerException.Message);
    }
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.InnerException.Message);
}

Console.WriteLine("Cau!");
