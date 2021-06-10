using System;

class Program
{
    static string CapitalizeString(string s)
    {
        //розбиваємо текст на слова
        var parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < parts.Length; i++)
        {
            //отримуємо першу літеру
            var firstLetter = parts[i].Substring(0, 1).ToUpper();
            //з'єднуємо символ та залишок від слова
            parts[i] = firstLetter + parts[i].Remove(0, 1);
        }

        //склеюємо масив рядків
        return string.Join(" ", parts);
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть текст для перетворення: ");
        var s = Console.ReadLine();

        var result = CapitalizeString(s);
        Console.WriteLine($"Результат: {result}");

        Console.ReadLine();
    }
}
