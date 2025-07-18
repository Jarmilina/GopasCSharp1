namespace lab09_01_Resources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream();

            try
            {
                fs.Open();
                int invalidOperation = int.Parse("Invalid"); // FormatException
            }
            finally
            {
                fs.Close();
            }
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
