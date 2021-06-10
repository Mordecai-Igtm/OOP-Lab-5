using System;

class Program
{
    static bool IsPalindrom(string text)
    {
        //видаляємо пробіли
        var s = text.Replace(" ", string.Empty);
        //переводимо в нижній регістр
        s = s.ToLower();
        //індекс останнього символу
        int lastIndex = s.Length - 1;
        for (int i = 0; i < s.Length / 2; i++)
        {
            //якщо символи не однакові, повертаємо false
            if (s[i] != s[lastIndex - i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть рядок для перевірки: ");
        var text = Console.ReadLine();
        var res = IsPalindrom(text) ? string.Empty : "не ";
        Console.WriteLine($"Рядок \"{text}\" {res}є паліндромом");
        Console.ReadLine();
    }
}
