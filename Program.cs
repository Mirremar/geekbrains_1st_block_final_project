string[] ReadData()
{
    Console.WriteLine("Введите количество строк");
    int strAmount = int.Parse(Console.ReadLine() ?? "0");
    string[] strArray = new string[strAmount];
    string temp = String.Empty;
    for (int i = 0; i < strAmount; i++)
    {
        Console.WriteLine("Введите " + (i+1) + " строку");
        temp = Console.ReadLine();
        strArray[i] = temp;
    }
    return strArray;
}

string[] TransformData(string[] input)
{
    string concatenated = String.Empty;
    string[] result = new string[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            concatenated += (input[i] + " ");
        }
    }
    result = concatenated.TrimEnd().Split(" ");
    return result;
}

void PrintResult(string[] result)
{
    for (int i=0;i<result.Length;i++)
    {
        if (i == result.Length - 1)
        {
            Console.Write(result[i]);
        }
        else
        {
            Console.Write(result[i] + " ");
        }
    }
}

string[] testArray = ReadData();
string[] result = TransformData(testArray);
PrintResult(result);
Console.ReadLine();
