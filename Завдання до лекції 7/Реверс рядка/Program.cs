using System;

class Program
{
    static string Reverse(string str)
    {
        //змінна для зберігання результату
        var retValue = string.Empty;
        foreach (var symbol in str)
        {
            //приклеюємо символ на початок рядка
            retValue = symbol + retValue;
        }

        return retValue;
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть текст для реверсування: ");
        var s = Console.ReadLine();
        Console.WriteLine($"Реверс рядка: {Reverse(s)}");
        Console.ReadLine();
    }
}
