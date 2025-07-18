WebHelperClassic whc1 = new WebHelperClassic();
Console.WriteLine(whc1.GetHeader("Gopas"));
Console.WriteLine(whc1.GetLink("Gopas", "www.gopas.cz"));

Console.WriteLine(WebHelperStatic.GetHeader("Gopas"));
Console.WriteLine(WebHelperStatic.GetLink("Gopas", "www.gopas.cz"));
class WebHelperClassic
{
    public string GetHeader(string header)
    {
        return $"<h1>{header}</h1>";
    }

    public string GetLink(string header,string link)
    {
        return "<a href=\"http:" + link + "\">" + header + "</a>";
    }
}

class WebHelperStatic
{
    public static string GetHeader(string header)
    {
        return $"<h1>{header}</h1>";
    }

    public static string GetLink(string header, string link)
    {
        return "<a href=\"http:" + link + "\">" + header + "</a>";
    }
}