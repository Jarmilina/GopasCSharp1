Employee employee1;

Console.WriteLine("Enter First Name:");
employee1.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name:");
employee1.LastName = Console.ReadLine();

Console.WriteLine("Enter Age:");
employee1.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Salary:");
employee1.Salary = decimal.Parse(Console.ReadLine());

Console.WriteLine("Name: {0} {1}\nAge: {2}\nSalary:{3:0.00}",
    employee1.FirstName,
    employee1.LastName,
    employee1.Age,
    employee1.Salary);

struct Employee
{
    public string FirstName;
    public string LastName;
    public int Age;
    public decimal Salary;
}