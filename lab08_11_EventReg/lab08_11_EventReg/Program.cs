//using System.Timers.Timer;

namespace lab08_11_EventReg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Timer timer = new Timer();
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += Timer_Elapsed;
            timer1.Enabled = true;
            System.Timers.Timer timer2 = new System.Timers.Timer();
            timer2.Interval = 3000;
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Enabled = true;
            Console.ReadKey();
        }

        private static void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //((System.Timers.Timer)sender).Enabled = false;
            Console.WriteLine("World");
            ((System.Timers.Timer)sender).Enabled = false; //casting object (timer2) to Timer
        }

        public static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
