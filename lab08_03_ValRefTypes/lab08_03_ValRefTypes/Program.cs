////Ex 68
////Employee e1 = new Employee();
//Employee e1;

//e1.FirstName = "John";
//e1.LastName = "Doe";
//Console.WriteLine("Employee1: ");
//Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);

//Employee e2;

//e2 = e1;

//Console.WriteLine("Employee2: ");
//Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
//Console.WriteLine(" ");

//e2.FirstName = "Paul";
//Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
//Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);
//struct Employee
//{
//    public string FirstName;
//    public string LastName;
//}

////Ex 69
//Employee e1 = new Employee();

//e1.FirstName = "John";
//e1.LastName = "Doe";
//Console.WriteLine("Employee1: ");
//Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);

//Employee e2;

//e2 = e1;

//Console.WriteLine("Employee2: ");
//Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
//Console.WriteLine(" ");

//e2.FirstName = "Paul";
//Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
//Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);
//class Employee
//{
//    public string FirstName;
//    public string LastName;
//}

//Ex 70
Employee e1 = new Employee();

e1.FirstName = "John";
e1.LastName = "Doe";
Console.WriteLine("Employee1: ");
Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);

Employee e2;

e2 = e1;

Console.WriteLine("Employee2: ");
Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
Console.WriteLine(" ");

e2.FirstName = "Paul";
Console.WriteLine("FirstName = {0}, LastName = {1}", e2.FirstName, e2.LastName);
Console.WriteLine("FirstName = {0}, LastName = {1}", e1.FirstName, e1.LastName);

e1.SetSalary(45_000);
Console.WriteLine("Salary of emlpyee1 is: {0}", e1.GetSalary());
class Employee
{
    public string FirstName;
    public string LastName;
    private decimal salary;

    public decimal GetSalary()
    {
        return this.salary;
    }

    public void SetSalary(decimal salary)
    {
        this.salary = salary;
    }
}