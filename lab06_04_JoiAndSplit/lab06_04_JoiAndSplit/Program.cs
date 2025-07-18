List<string> csvData = new List<string>
{
    "John,Doe,30,Engineer",
    "Jane,Smith,25,Designer",
    "Bob,Johnson,45,Manager"
};

//string[] fields = csvData[0].Split(',');

//Console.WriteLine($"Item #1");
//Console.WriteLine($"\tName: {fields[0]} {fields[1]}");
//Console.WriteLine($"\tAge {fields[2]}");
//Console.WriteLine($"\tOccupation: {fields[3]}");

//foreach (var item in fields)
//{
//    Console.WriteLine(item);
//}

for (int i = 0; i < csvData.Count; i++)
{
    string[] fields = csvData[i].Split(',');

    Console.WriteLine($"Item #{i + 1}");
    Console.WriteLine($"\tName: {fields[0]} {fields[1]}");
    Console.WriteLine($"\tAge {fields[2]}");
    Console.WriteLine($"\tOccupation: {fields[3]}");

    int age = int.Parse(fields[2]);
    //age += 1;
    fields[2] = (age + 1).ToString();
    //Console.WriteLine(age);
    //csvData[i] = string.Join(',', fields);
    csvData[i] = string.Join(';', fields);
}
csvData.Insert(0, "FirstName;LastName;Age;Occupation");

foreach (var line in csvData)
{
    Console.WriteLine(line);
}

//Console.WriteLine(string.Join('^', fields));

