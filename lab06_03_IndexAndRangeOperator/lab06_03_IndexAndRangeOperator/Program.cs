//string text = "ABCDEFGH";
//Console.WriteLine(text[0]);

////Console.WriteLine(text[text.Length]);
////Console.WriteLine(text[text.Length -1]);
////Console.WriteLine(text[-1]); //error (only in Python)
//Console.WriteLine(text[^1]);
//Console.WriteLine(text[^2]);
//Console.WriteLine(text[^3]);
//Console.WriteLine(text[^4]);

//for (int i = 0; i < text.Length; i++)
//{
//    Console.WriteLine($"{text[i]} - {text[^(i+1)]}");
//}

//Ex 52
char[] GetSubArray(char[] text, int start, int end)
{
    char[] newArray = new char[end - start];
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = text[i + start];
	}

	return newArray;
}

string text = "ABCDEFGH";
int start = 1;
int end = 5;
//char[] list = GetSubArray(text.ToCharArray(), start, end);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

Range range = new Range(start, end);
Console.WriteLine($"Start: {range.Start}");
Console.WriteLine($"End: {range.End}");
Console.WriteLine($"Range: {range}");
Console.WriteLine(text[range]);

//Console.WriteLine(text[1..5]);
Console.WriteLine(text[start..end]);
Console.WriteLine(text[0..^1]);
Console.WriteLine("");
Console.WriteLine(text[1..]);
Console.WriteLine(text[^2..^0]);