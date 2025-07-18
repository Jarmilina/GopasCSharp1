Car car1 = new Car("Peugeot", 120, true);
Car car2 = new Car("Toyota", 0, false);

Console.WriteLine(car1.GetInfo());
Console.WriteLine(car2.GetInfo());

car1.SpeedDownBy(10);
car2.SpeedDownBy(10);

car1.Start();

Console.WriteLine(car1.GetInfo());
Console.WriteLine(car2.GetInfo());
class Car
{
    private string manufacturer;
    private int speed;
    bool isStarted;

    public Car(string manufacturer, int speed, bool isStarted)
    {
        this.manufacturer = manufacturer;
        this.speed = speed;
        this.isStarted = isStarted;
    }
    public void Start()
    {
        this.isStarted = true;
        Console.WriteLine($"Car has started.");
    }
    public void SpeedUpBy(int value)
    {
        if (!this.isStarted)
        {
            Console.WriteLine("Please start car first.");
        }
        else
        {
            this.speed += value;
            Console.WriteLine($"New speed: {speed} km/h.");
        }
    }

    public void SpeedDownBy(int value)
    {
        if (value >= speed)
        {
            this.speed = 0;
            this.isStarted = false;
            Console.WriteLine("Car has stopped.");
            return;
        }
        this.speed -= value;
    }

    public string GetInfo()
    {
        return $"Car Information:\n\tManufacturer: {manufacturer}\n\tSpeed: {speed}\n\tIsStarted: {isStarted}";
    }
}