using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ruVowels = "АаЕеЁёИиОоУуЫыЭэЮюЯя";
            string str;

            Console.Write("Строка: ");
            str = Console.ReadLine();

            string[] words = str.Split(new Char[] { ' ', '\t', ',', '.', '!', '?' });
            int cntWords = words.Length;
            int[] counters = new int[cntWords];
            for (int i = 0; i < cntWords; ++i)
            {
                for (int j = 0; j < words[i].Length; ++j)
                    if (ruVowels.IndexOf(words[i][j]) != -1)
                        counters[i]++;
            }
            int maxVowels = counters[0];
            for (int i = 1; i < cntWords; ++i)
                if (counters[i] > maxVowels)
                    maxVowels = counters[i];

            Console.WriteLine("Слово(а) з найбільшою кількістю голосних букв:");
            for (int i = 0; i < cntWords; ++i)
                if (counters[i] == maxVowels)
                    Console.WriteLine(words[i]);

            Console.ReadLine();
        }
    }
}
