namespace lab08_08_AutoProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Joe";
            e1.Salary = 50_000;
            Console.WriteLine($"Name: {e1.Name}, Salary: {e1.Salary}");
            Console.WriteLine(e1.AnnualSalary);
            //Employee.AnnualSalary
        }

        class Employee
        {
            //private string _name;
            //public string Name
            //{
            //    get { return _name; }
            //    set { _name = value; }
            //}

            public string Name { get; set; }
            //private decimal _salary;

            //public decimal Salary
            //{
            //    get { return _salary; }
            //    set { _salary = value; }
            //}
            public decimal Salary { get; set; }

            public decimal AnnualSalary
            {
                get { return Salary * 12; }
            }

            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }

            private string _city;

            public string City
            {
                get { return _city; }
                set { _city = value; }
            }

            private string _address;

            private string _region;

            public string Region
            {
                get { return _region; }
                set { _region = value; }
            }

            private string _country;

            public string Country
            {
                get { return _country; }
                set { _country = value; }
            }


            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Note { get; set; }


        }
    }
}
