namespace lab08_07_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish1 = new Fish();
            //fish1.SetWeight(20);
            //fish1.Weight = 20;
            fish1.Weight = 20;
            Console.WriteLine(fish1.GetWeight());
        }

        class Fish
        {
            private int _weight;
            public int Weight
            {
                get { return this._weight; }
                set 
                {
                    if (value < 0)
                    {
                        throw new InvalidOperationException("Invalid value");
                    }
                    else
                    {
                        this._weight = value;
                    }
                }
            }

            public void SetWeight(int weight)
            {
                if (weight < 0)
                {
                    throw new InvalidOperationException("Invalid value");
                }
                this._weight = weight;
            }

            public int GetWeight()
            {
                return this._weight;
            }
        }
    }
}
