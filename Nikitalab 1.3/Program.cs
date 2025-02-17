using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вводим два слова
        Console.WriteLine("Введите первое слово:");
        string word1 = Console.ReadLine();

        Console.WriteLine("Введите второе слово:");
        string word2 = Console.ReadLine();

        // Получаем результат
        var result = WordChecker.CheckLettersInWord(word1, word2);

        // Выводим результат
        Console.WriteLine(string.Join(" ", result));
    }
}

public class WordChecker
{
    public static List<string> CheckLettersInWord(string word1, string word2)
    {
        var result = new List<string>();
        var checkedLetters = new HashSet<char>();

        foreach (char c in word1)
        {
            // Пропускаем букву, если она уже была проверена
            if (checkedLetters.Contains(c)) continue;

            checkedLetters.Add(c);
            if (word2.Contains(c))
            {
                result.Add("да");
            }
            else
            {
                result.Add("нет");
            }
        }

        return result;
    }
}
