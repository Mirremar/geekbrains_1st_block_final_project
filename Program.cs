﻿string[] ReadData()
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
