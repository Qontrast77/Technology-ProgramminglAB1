using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите длину последовательности:");
        int length = int.Parse(Console.ReadLine());

        int[] sequence = new int[length];
        Console.WriteLine("Введите элементы последовательности:");
        for (int i = 0; i < length; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        var result = FindConsecutive.FindConsecutiveNumbers(sequence, n);

        if (result != null)
        {
            Console.WriteLine($"Найдена последовательность из {n} одинаковых чисел, начиная с индекса {result.Item1}.");
        }
        else
        {
            Console.WriteLine("Не найдено последовательности из одинаковых соседних чисел.");
        }
    }
}

public static class FindConsecutive
{
    // Метод для поиска последовательности из n одинаковых соседних чисел
    public static Tuple<int, int>? FindConsecutiveNumbers(int[] sequence, int n)
    {
        for (int i = 0; i <= sequence.Length - n; i++)
        {
            bool isValid = true;
            for (int j = i + 1; j < i + n; j++)
            {
                if (sequence[i] != sequence[j])
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                return Tuple.Create(i, i + n - 1);  // Возвращаем 0-индексацию
            }
        }
        return null; // Нет последовательности
    }

    
}