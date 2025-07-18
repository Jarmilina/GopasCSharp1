//datetool.exe /?
//JarmilaCommandLine.exe;
//string[] arguments = { "/?", "/d", "/t" };

string Help()
{
    string help = "Usage: JarmilaCommandLine [options] [options]\n" +
        "Options:\n" +
        "/?         Shows this help\n" +
        "/d         Shows current date\n" +
        "/t         Shows current time";

    return help;
}

string ShowCurrentDate()
{
    return DateTime.Now.Date.ToShortDateString();
}

TimeSpan ShowCurrentTime()
{
    return DateTime.Now.TimeOfDay;
}
//Console.WriteLine(args.Length);

if (args.Contains("/d"))
{
    Console.WriteLine(ShowCurrentDate());
}
if (args.Contains("/t"))
{
    Console.WriteLine(ShowCurrentTime());
}
if (args.Contains("/?"))
{
    Console.WriteLine(Help());
}