using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var translations = new Dictionary<string, string>
        {
            { "Привіт", "Hello" },
            { "Прощавай", "Bye" }
        };

        Console.WriteLine("Введіть фразу українською:");
        string input = Console.ReadLine();

        if (translations.ContainsKey(input))
        {
            Console.WriteLine($"Переклад: {translations[input]}");
        }
        else
        {
            Console.WriteLine("Переклад недоступний.");
        }
    }
}
