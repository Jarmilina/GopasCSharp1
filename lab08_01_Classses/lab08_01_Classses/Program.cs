// Ex 65

BankAcccount bankAccount1 = new BankAcccount();
BankAcccount bankAccount2 = new BankAcccount();

bankAccount1.AccountNumber = "123456789/0100";
bankAccount1.Owner = "John Doe";
bankAccount2.AccountNumber = "987654321/0300";
bankAccount2.Owner = "Jane Doe";

//Console.WriteLine($"Account: {bankAccount1.AccountNumber}" + $", Owner: {bankAccount1.Owner}" + $", Balance: {bankAccount1.Balance}");
//Console.WriteLine($"Account: {bankAccount2.AccountNumber}" + $", Owner: {bankAccount2.Owner}" + $", Balance: {bankAccount2.Balance}");
Console.WriteLine(bankAccount1.GetDetailInfo());
Console.WriteLine(bankAccount2.GetDetailInfo());

bankAccount1.Deposit(10000);
bankAccount2.Deposit(20000);

Console.WriteLine(bankAccount1.GetDetailInfo());
Console.WriteLine(bankAccount2.GetDetailInfo());

bankAccount1.Withdrawal(5000);
bankAccount2.Withdrawal(2000);

Console.WriteLine(bankAccount1.GetDetailInfo());
Console.WriteLine(bankAccount2.GetDetailInfo());

bankAccount1.Withdrawal(50000);
Console.WriteLine(bankAccount1.GetDetailInfo());
Console.WriteLine(bankAccount2.GetDetailInfo());

//bankAccount1.Balance += 1000_000;
//Console.WriteLine(bankAccount1.GetDetailInfo());
class BankAcccount
{
    public string AccountNumber;
    public string Owner;
    decimal balance;

    public string GetDetailInfo()
    {
        //string details = $"Account: {this.AccountNumber}" + $", Owner: {this.Owner}" + $", Balance: {this.Balance}";
        return $"Account: {this.AccountNumber}" + $", Owner: {this.Owner}" + $", Balance: {this.balance}";
    }

    public void Deposit(Decimal amount)
    {
        this.balance += amount;
        Console.WriteLine($"{amount} deposited. New balance: {this.balance}");
    }

    public void Withdrawal(decimal amount)
    {
        //if (amount <= this.Balance)
        //{
        //    this.Balance -= amount;
        //    Console.WriteLine($"{amount} withdrawn. New balance: {this.Balance}");
        //}
        if (amount > this.balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }
        else
        {
            Console.WriteLine($"{amount} can't be withdrawn, not enough balance, balance is {this.balance}");
        }
    }
}
