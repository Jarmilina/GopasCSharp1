namespace lab08_09_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car();
            Car c1 = new Car("VW", "Golf", 2024);
            c1.DisplayInfo();
            Car c2 = new Car("Ford", "Mustang", 2022);
            c2.DisplayInfo();
            Car c3 = new Car("BMV", "XS", 2021);
            c3.DisplayInfo();

            DateTime defaultDate = new DateTime();
            Console.WriteLine("Default DateTime:" + defaultDate);

            DateTime specificDate = new DateTime(2023, 9, 10);
            Console.WriteLine("Specific DateTime:" + specificDate);

            DateTime detailedDate = new DateTime(2023, 9, 10, 15, 30, 0);
            Console.WriteLine("Detailed DateTime:" + detailedDate);
        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            //public Car()
            //{
            //    this.Make = "VW";
            //    this.Model = "Golf";
            //    this.Year = 2024;
            //}
            public Car(string make, string model, int year)
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Car {this.Make}: '{this.Model}' {this.Year}");
            }
        }
    }
}
