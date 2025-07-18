//Ex 43
int CalculateNetIncome(int income, int expenses = 0, int tax = 0, int discounts = 0)
{
    return income - expenses - tax - discounts;
}

//Console.WriteLine(CalculateNetIncome(50000, 2000, 5000, 2000));
//Console.WriteLine(CalculateNetIncome(income: 50000, expenses: 2000, tax: 5000, discounts: 2000));
Console.WriteLine(CalculateNetIncome(discounts: 2000, tax: 5000, income: 50000, expenses: 2000));
Console.WriteLine(CalculateNetIncome(income: 50000, tax: 5000));
Console.WriteLine(CalculateNetIncome(50000, 5000));
Console.WriteLine(CalculateNetIncome(50000, discounts: 5000));