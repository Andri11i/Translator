using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var translations = new Dictionary<string, string>
        {
            { "Hello", "Привіт" },
            { "Bye", "Прощавай" }
        };

        Console.WriteLine("Enter a phrase in English:");
        string input = Console.ReadLine();

        if (translations.ContainsKey(input))
        {
            Console.WriteLine($"Translation: {translations[input]}");
        }
        else
        {
            Console.WriteLine("No translation available.");
        }
    }
}
