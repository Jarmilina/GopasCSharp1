namespace lab09_01_Resources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream();
            fs.Open();
        }

        class FileStream
        {
            public void Open()
            {
                Console.WriteLine("Opening file");
            }

            public void Close()
            {
                Console.WriteLine("Closing file");
            }

        }
    }
}
