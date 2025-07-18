namespace lab08_10_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Cici");
            Spider s1 = new Spider("Spidee");
            //c1.NumberOfLegs = 4;
            //s1.NumberOfLegs = 8;
            //c1.Name = "Cici";
            //s1.Name = "Spidee";

            Console.WriteLine(c1.NumberOfLegs);
            Console.WriteLine(s1.NumberOfLegs);
        }

        class Animal
        {
            public int NumberOfLegs { get; set; }
            public string Name { get; set; }

            public Animal(string name)
            {
                this.Name = name;
            }
        }

        class Cat : Animal
        {
            public Cat(string name) :base(name)
            {
                this.NumberOfLegs = 4;
            }
        }

        class Spider : Animal
        {
            public Spider(string name) :base(name)
            {
                this.NumberOfLegs = 8;
            }
        }
    }
}
