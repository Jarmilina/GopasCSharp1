//string s = Console.ReadLine() ?? "";
//Console.WriteLine(s?.Length);

string accountName = "JohnDoe";
//Account account = GetAccount(accountName);
Account? account = GetAccount(accountName);
//Console.WriteLine($"Account name: {account.Name}");
//Console.WriteLine($"Account balance: {account.Balance}");

if (account == null) //Check if balance is not null
{
    Console.WriteLine("No account");
}
else
{
    Console.WriteLine($"Account name: {account.Name}");
    Console.WriteLine($"Account balance: {account.Balance}");
}

    //Account GetAccount(string accountName)
    Account? GetAccount(string accountName)
    {
        Random random = new Random();
        //Add random null
        int chance = random.Next(0, 100);
        if (chance < 30)
        {
            return null;
        }

        Account account = new Account();
        account.Name = accountName;
        account.Balance = random.Next(10000, 50000);

        return account;
    }

class Account
{
    public string Name = "";
    public decimal Balance = 0m;
}
