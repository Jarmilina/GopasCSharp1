
using System.Text;

//string with = "";
//System.Text.StringBuilder sb = new System.Text.StringBuilder();
StringBuilder sb = new StringBuilder();

System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
sw.Start();
Console.WriteLine("Start");

for (int i = 0; i < 100_000; i++)
{
    //with += "A";
    sb.Append("A");
}
string s = sb.ToString();
Console.WriteLine("Stop");
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds + "ms");
